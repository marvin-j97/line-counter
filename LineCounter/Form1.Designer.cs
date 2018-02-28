namespace LineCounter
{
  partial class Form1
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnFolderSelector = new System.Windows.Forms.Button();
            this.TxtSelectedFolder = new System.Windows.Forms.TextBox();
            this.BtnCount = new System.Windows.Forms.Button();
            this.TxtLineCount = new System.Windows.Forms.Label();
            this.CbSubFolders = new System.Windows.Forms.CheckBox();
            this.TxtFileFormats = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.BtnAbort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnFolderSelector
            // 
            this.BtnFolderSelector.Location = new System.Drawing.Point(197, 12);
            this.BtnFolderSelector.Name = "BtnFolderSelector";
            this.BtnFolderSelector.Size = new System.Drawing.Size(75, 23);
            this.BtnFolderSelector.TabIndex = 0;
            this.BtnFolderSelector.Text = "...";
            this.BtnFolderSelector.UseVisualStyleBackColor = true;
            this.BtnFolderSelector.Click += new System.EventHandler(this.BtnFolderSelector_Click);
            // 
            // TxtSelectedFolder
            // 
            this.TxtSelectedFolder.Location = new System.Drawing.Point(12, 15);
            this.TxtSelectedFolder.Name = "TxtSelectedFolder";
            this.TxtSelectedFolder.Size = new System.Drawing.Size(179, 20);
            this.TxtSelectedFolder.TabIndex = 2;
            this.TxtSelectedFolder.TextChanged += new System.EventHandler(this.TxtSelectedFolder_TextChanged);
            // 
            // BtnCount
            // 
            this.BtnCount.Location = new System.Drawing.Point(197, 41);
            this.BtnCount.Name = "BtnCount";
            this.BtnCount.Size = new System.Drawing.Size(75, 23);
            this.BtnCount.TabIndex = 3;
            this.BtnCount.Text = "Count";
            this.BtnCount.UseVisualStyleBackColor = true;
            this.BtnCount.Click += new System.EventHandler(this.BtnCount_Click);
            // 
            // TxtLineCount
            // 
            this.TxtLineCount.AutoSize = true;
            this.TxtLineCount.Location = new System.Drawing.Point(12, 113);
            this.TxtLineCount.Name = "TxtLineCount";
            this.TxtLineCount.Size = new System.Drawing.Size(78, 13);
            this.TxtLineCount.TabIndex = 4;
            this.TxtLineCount.Text = "0 lines in 0 files";
            // 
            // CbSubFolders
            // 
            this.CbSubFolders.AutoSize = true;
            this.CbSubFolders.Checked = true;
            this.CbSubFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbSubFolders.Location = new System.Drawing.Point(12, 75);
            this.CbSubFolders.Name = "CbSubFolders";
            this.CbSubFolders.Size = new System.Drawing.Size(108, 17);
            this.CbSubFolders.TabIndex = 5;
            this.CbSubFolders.Text = "Count sub folders";
            this.CbSubFolders.UseVisualStyleBackColor = true;
            // 
            // TxtFileFormats
            // 
            this.TxtFileFormats.Location = new System.Drawing.Point(12, 43);
            this.TxtFileFormats.Name = "TxtFileFormats";
            this.TxtFileFormats.Size = new System.Drawing.Size(179, 20);
            this.TxtFileFormats.TabIndex = 6;
            this.TxtFileFormats.Text = "*.cpp|*.c|*.h|*.cs|*.py";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(126, 75);
            this.ProgressBar.MarqueeAnimationSpeed = 5;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(145, 17);
            this.ProgressBar.Step = 1;
            this.ProgressBar.TabIndex = 7;
            this.ProgressBar.Visible = false;
            // 
            // BtnAbort
            // 
            this.BtnAbort.Location = new System.Drawing.Point(196, 103);
            this.BtnAbort.Name = "BtnAbort";
            this.BtnAbort.Size = new System.Drawing.Size(75, 23);
            this.BtnAbort.TabIndex = 8;
            this.BtnAbort.Text = "Abort";
            this.BtnAbort.UseVisualStyleBackColor = true;
            this.BtnAbort.Visible = false;
            this.BtnAbort.Click += new System.EventHandler(this.BtnAbort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 139);
            this.Controls.Add(this.BtnAbort);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.TxtFileFormats);
            this.Controls.Add(this.CbSubFolders);
            this.Controls.Add(this.TxtLineCount);
            this.Controls.Add(this.BtnCount);
            this.Controls.Add(this.TxtSelectedFolder);
            this.Controls.Add(this.BtnFolderSelector);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 177);
            this.MinimumSize = new System.Drawing.Size(300, 177);
            this.Name = "Form1";
            this.Text = "LineC#ounter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button BtnFolderSelector;
    private System.Windows.Forms.TextBox TxtSelectedFolder;
    private System.Windows.Forms.Button BtnCount;
    private System.Windows.Forms.Label TxtLineCount;
    private System.Windows.Forms.CheckBox CbSubFolders;
    private System.Windows.Forms.TextBox TxtFileFormats;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button BtnAbort;
    }
}

