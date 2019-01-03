using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LineCounter
{
    public partial class Form1 : Form
    {
        private string directory;
        private List<string> files;
        private List<string> searchPatterns;
        private SearchOption searchOption;
        private CountResult countResult;
        private readonly BackgroundWorker worker;

        private struct CountResult
        {
            public int LineCount;
            public int FileCount;
        }

        public Form1()
        {
            InitializeComponent();
            worker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true,
            };
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_Completed;
            worker.ProgressChanged += Worker_Progress;
        }

        private static IEnumerable<string> GetFiles(string dir, string pattern, SearchOption option)
        {
            string[] foundFiles = null;
            try
            {
                foundFiles = Directory.GetFiles(dir, pattern, option);
            }
            catch (Exception)
            {
                // ignored
            }

            if (foundFiles == null) yield break;
            foreach (var t in foundFiles)
            {
                yield return t;
            }
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (var pattern in searchPatterns)
            {
                worker.ReportProgress(0, "Looking for files");
                try
                {
                    foreach (var file in GetFiles(directory, pattern, searchOption))
                    {
                        files.Add(file);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    // no access - move on
                    Debug.WriteLine("Unaut. Exception!!");
                }
                catch (Exception)
                {
                    // severe exception
                    countResult.FileCount = -1;
                    worker.CancelAsync();
                }
            }

            if (worker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            var numberOfFiles = countResult.FileCount = files.Count;

            for (var i = 0; i < numberOfFiles; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                countResult.LineCount += File.ReadLines(files[i]).Count();
                worker.ReportProgress(Convert.ToInt32((double)i / numberOfFiles * 100), i + ","+numberOfFiles);
            }
        }

        private void Worker_Progress(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState.ToString() == "Looking for files")
            {
              TxtLineCount.Text = e.UserState.ToString();
            }
            else
            {
                var info = e.UserState.ToString().Split(',');
                TxtLineCount.Text = $@"Counting {info[0]} out of {info[1]} files";
                ProgressBar.Value = e.ProgressPercentage;
            }
        }

        private void Worker_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            ProgressBar.Visible = false;
            BtnAbort.Visible = false;

            if (countResult.FileCount != -1)
            {
                TxtLineCount.Text = string.Format($"{countResult.LineCount} lines in {countResult.FileCount} files");
            }
            else
            {
                TxtLineCount.Text = @"Invalid extension formatting!";
            }
        }

        private void Form1_Load(object sender, EventArgs e) => SetFolder(Directory.GetCurrentDirectory());

        private void SetFolder(string folder)
        {
            directory = folder;
            TxtSelectedFolder.Text = directory;
        }

        private void BtnFolderSelector_Click(object sender, EventArgs e)
        {
            var folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                SetFolder(folderDialog.SelectedPath);
            }
        }

        private void BtnCount_Click(object sender, EventArgs e)
        {
            searchOption = CbSubFolders.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            ProcessDirectory(TxtFileFormats.Text);
        }

        private void ProcessDirectory(string pattern)
        {
            if (worker.IsBusy)
            {
                return;
            }

            countResult.LineCount = 0;
            countResult.FileCount = 0;
            ProgressBar.Value = 0;
            searchPatterns = pattern.Split('|').ToList();
            files = new List<string>();
            ProgressBar.Visible = true;
            BtnAbort.Visible = true;
            TxtLineCount.Text = @"Counting...";
            worker.RunWorkerAsync();
        }

        private void TxtSelectedFolder_TextChanged(object sender, EventArgs e) => SetFolder(TxtSelectedFolder.Text);

        private void BtnAbort_Click(object sender, EventArgs e) => worker.CancelAsync();
    }
}
