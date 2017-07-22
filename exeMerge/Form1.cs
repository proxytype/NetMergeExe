using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace exeMerge
{
    public partial class Form1 : Form
    {
        private const string PATH_SYSTEM32 = "system32";
        private const string PATH_MICROSOFT_NET = "microsoft.net";
        private const string NET_COMPILER = "csc.exe";

        private const string ERROR_NO_FRAMEWORKS_FOUND = "No .Net Frameworks Founds!";

        private const string ERROR_DISPLAY_FILE_MISSING = "Display File Missing!";
        private const string ERROR_BACKGROUND_FILE_MISSING = "Background File Missing!";
        private const string ERROR_OUTPUT_FILE_MISSING = "Output File Missing!";
        private const string ERROR_NO_FRAMEWORK_SELECTED = "No Framework Selected!";

        private const string PROGRESS_PROCESSING = "Processing...";
        private const string PROGRESS_DONE = "Complete!";

        private string windowsPath = String.Empty;
        private string selectedFrameWork = String.Empty;
        private string displayFile = String.Empty;
        private string backgroundFile = String.Empty;
        private string outputFile = String.Empty;

        private MergeWorker worker;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            worker = new MergeWorker();
            worker.mergeCompleteHandler += Worker_mergeCompleteHandler;

            lbl_error.Text = "";

            windowsPath = Environment.GetFolderPath(Environment.SpecialFolder.System).ToLower().Replace(PATH_SYSTEM32, "");
            loadFrameworkList(windowsPath + PATH_MICROSOFT_NET);
            loadExportFolders();
        }

        private void Worker_mergeCompleteHandler()
        {
            lbl_error.Text = PROGRESS_DONE;
        }

        private void loadExportFolders()
        {
            foreach (Environment.SpecialFolder folder in Enum.GetValues(typeof(Environment.SpecialFolder)))
            {
                string sFolder = folder.ToString();

                chk_background_export.Items.Add(sFolder);
                chk_display_export.Items.Add(sFolder);
            }

            chk_display_export.SelectedIndex = 0;
            chk_background_export.SelectedIndex = 0;
        }

        private void loadFrameworkList(string frameworksPath)
        {
            if (Directory.Exists(frameworksPath))
            {
                string[] files = Directory.GetFiles(frameworksPath, "csc.exe", SearchOption.AllDirectories);
                if (files.Length != 0)
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        chk_framework.Items.Add(files[i]);
                    }
                }
            }
            else
            {
                lbl_error.Text = ERROR_NO_FRAMEWORKS_FOUND;
            }
        }

        private void chk_framework_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < chk_framework.Items.Count; ++ix)
            {
                if (ix != e.Index)
                {
                    chk_framework.SetItemChecked(ix, false);
                }
                else
                {
                    CheckedListBox ch = (CheckedListBox)sender;
                    selectedFrameWork = ch.Text;
                }
            }


        }

        private void btn_merge_files_Click(object sender, EventArgs e)
        {
            if (selectedFrameWork == String.Empty)
            {
                updateErrorLabel(ERROR_NO_FRAMEWORK_SELECTED, Color.Red);
                return;
            }

            if (displayFile == String.Empty)
            {
                updateErrorLabel(ERROR_DISPLAY_FILE_MISSING, Color.Red);
                return;
            }

            if (backgroundFile == String.Empty)
            {
                updateErrorLabel(ERROR_BACKGROUND_FILE_MISSING, Color.Red);
                return;
            }

            if (outputFile == String.Empty)
            {
                updateErrorLabel(ERROR_OUTPUT_FILE_MISSING, Color.Red);
                return;
            }


            updateErrorLabel(PROGRESS_PROCESSING, Color.Green);

            worker.execute(displayFile, chk_display_export.SelectedItem.ToString(), backgroundFile, chk_background_export.SelectedItem.ToString(), outputFile, selectedFrameWork);

        }


        private void updateErrorLabel(string message, Color selectedColor)
        {
            lbl_error.Text = message;
            lbl_error.ForeColor = selectedColor;
        }

        private void btn_display_file_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName != "")
                {
                    displayFile = openFileDialog1.FileName;
                    txb_display_file.Text = displayFile;
                }
            }
        }

        private void btn_background_file_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName != "")
                {
                    backgroundFile = openFileDialog1.FileName;
                    txb_background_file.Text = backgroundFile;
                }
            }
        }

        private void btn_outpot_file_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName != "")
                {
                    outputFile = saveFileDialog1.FileName;
                    txb_outpot_file.Text = outputFile;
                }
            }
        }
    }
}
