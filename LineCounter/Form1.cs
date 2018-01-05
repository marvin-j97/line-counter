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

    public struct CountResult
    {
      public int lineCount;
      public int fileCount;
    }

    public Form1()
    {
      InitializeComponent();
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
      SearchOption searchOption;

      if (cbSubFolders.Checked)
      {
        searchOption = SearchOption.AllDirectories;
      }
      else
      {
        searchOption = SearchOption.TopDirectoryOnly;
      }

      CountResult cr = ProcessDirectory(txtFileFormats.Text, searchOption);
      txtLineCount.Text = String.Format($"{cr.lineCount} lines in {cr.fileCount} files");
    }

    private CountResult ProcessDirectory(string searchPattern, SearchOption searchOption)
    {
      CountResult cr;
      cr.lineCount = 0;
      cr.fileCount = 0;
      
      List<string> searchPatterns = new List<string>(searchPattern.Split('|'));
      List<string> files = new List<string>();

      foreach (string sp in searchPatterns)
      {
        files.AddRange(Directory.GetFiles(directory, sp, searchOption));
      }

      cr.fileCount = files.Count;

      foreach (string fileLocation in files)
      {
        cr.lineCount += File.ReadLines(fileLocation).Count();
      }

      return cr;
    }
  }
}
