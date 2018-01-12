using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    public struct CountResult
    {
      public int lineCount;
      public int fileCount;
    }

    public Form1()
    {
      InitializeComponent();

      backgroundWorker1.DoWork += backgroundWorker1_DoWork;
      backgroundWorker1.RunWorkerCompleted += backgroundWorker1_Completed;
      backgroundWorker1.WorkerReportsProgress = true;
      backgroundWorker1.WorkerSupportsCancellation = true;
    }

    private void backgroundWorker1_Completed(object sender, RunWorkerCompletedEventArgs e)
    {
      progressBar.Visible = false;

      if (countResult.fileCount != -1)
      {
        txtLineCount.Text = String.Format($"{countResult.lineCount} lines in {countResult.fileCount} files");
      }
      else
      {
        txtLineCount.Text = "Invalid extension formatting!";
      }
    }

    private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
      for (int i = 0; i < searchPatterns.Count; i++)
      {
        try
        {
          files.AddRange(Directory.GetFiles(directory, searchPatterns[i], searchOption));
        }
        catch(Exception)
        {
          countResult.fileCount = -1;
          backgroundWorker1.CancelAsync();
        }
      }

      if (backgroundWorker1.CancellationPending)
      {
        e.Cancel = true;
        return;
      }

      countResult.fileCount = files.Count;

      for (int i = 0; i < files.Count; i++)
      {
        countResult.lineCount += File.ReadLines(files[i]).Count();
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      setFolder(Directory.GetCurrentDirectory());
    }

    private void setFolder(string folder)
    {
      directory = folder;
      txtSelectedFolder.Text = directory;
    }

    private void btnFolderSelector_Click(object sender, EventArgs e)
    {
      var folderDialog = new FolderBrowserDialog();
      
      if (folderDialog.ShowDialog() == DialogResult.OK)
      {
        setFolder(folderDialog.SelectedPath);
      }
    }

    private void btnCount_Click(object sender, EventArgs e)
    {
      if (cbSubFolders.Checked)
      {
        searchOption = SearchOption.AllDirectories;
      }
      else
      {
        searchOption = SearchOption.TopDirectoryOnly;
      }

      ProcessDirectory(txtFileFormats.Text);
    }

    private void ProcessDirectory(string searchPattern)
    {
      if (backgroundWorker1.IsBusy)
        return;

      // Reset stuff
      countResult.lineCount = 0;
      countResult.fileCount = 0;
      searchPatterns = searchPattern.Split('|').ToList();
      files = new List<string>();

      // Count stuff
      progressBar.Visible = true;
      txtLineCount.Text = "Counting...";
      backgroundWorker1.RunWorkerAsync();
    }

    private void txtSelectedFolder_TextChanged(object sender, EventArgs e)
    {
      setFolder(txtSelectedFolder.Text);
    }
  }
}
