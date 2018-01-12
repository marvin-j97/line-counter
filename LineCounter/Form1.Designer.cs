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
      this.btnFolderSelector = new System.Windows.Forms.Button();
      this.txtSelectedFolder = new System.Windows.Forms.TextBox();
      this.btnCount = new System.Windows.Forms.Button();
      this.txtLineCount = new System.Windows.Forms.Label();
      this.cbSubFolders = new System.Windows.Forms.CheckBox();
      this.txtFileFormats = new System.Windows.Forms.TextBox();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.progressBar = new System.Windows.Forms.ProgressBar();
      this.SuspendLayout();
      // 
      // btnFolderSelector
      // 
      this.btnFolderSelector.Location = new System.Drawing.Point(197, 12);
      this.btnFolderSelector.Name = "btnFolderSelector";
      this.btnFolderSelector.Size = new System.Drawing.Size(75, 23);
      this.btnFolderSelector.TabIndex = 0;
      this.btnFolderSelector.Text = "...";
      this.btnFolderSelector.UseVisualStyleBackColor = true;
      this.btnFolderSelector.Click += new System.EventHandler(this.btnFolderSelector_Click);
      // 
      // txtSelectedFolder
      // 
      this.txtSelectedFolder.Location = new System.Drawing.Point(12, 15);
      this.txtSelectedFolder.Name = "txtSelectedFolder";
      this.txtSelectedFolder.Size = new System.Drawing.Size(179, 20);
      this.txtSelectedFolder.TabIndex = 2;
      this.txtSelectedFolder.TextChanged += new System.EventHandler(this.txtSelectedFolder_TextChanged);
      // 
      // btnCount
      // 
      this.btnCount.Location = new System.Drawing.Point(197, 41);
      this.btnCount.Name = "btnCount";
      this.btnCount.Size = new System.Drawing.Size(75, 23);
      this.btnCount.TabIndex = 3;
      this.btnCount.Text = "Count";
      this.btnCount.UseVisualStyleBackColor = true;
      this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
      // 
      // txtLineCount
      // 
      this.txtLineCount.AutoSize = true;
      this.txtLineCount.Location = new System.Drawing.Point(12, 113);
      this.txtLineCount.Name = "txtLineCount";
      this.txtLineCount.Size = new System.Drawing.Size(78, 13);
      this.txtLineCount.TabIndex = 4;
      this.txtLineCount.Text = "0 lines in 0 files";
      // 
      // cbSubFolders
      // 
      this.cbSubFolders.AutoSize = true;
      this.cbSubFolders.Checked = true;
      this.cbSubFolders.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbSubFolders.Location = new System.Drawing.Point(12, 75);
      this.cbSubFolders.Name = "cbSubFolders";
      this.cbSubFolders.Size = new System.Drawing.Size(108, 17);
      this.cbSubFolders.TabIndex = 5;
      this.cbSubFolders.Text = "Count sub folders";
      this.cbSubFolders.UseVisualStyleBackColor = true;
      // 
      // txtFileFormats
      // 
      this.txtFileFormats.Location = new System.Drawing.Point(12, 43);
      this.txtFileFormats.Name = "txtFileFormats";
      this.txtFileFormats.Size = new System.Drawing.Size(179, 20);
      this.txtFileFormats.TabIndex = 6;
      this.txtFileFormats.Text = "*.cpp|*.c|*.h|*.cs|*.py";
      // 
      // progressBar
      // 
      this.progressBar.Location = new System.Drawing.Point(126, 75);
      this.progressBar.MarqueeAnimationSpeed = 5;
      this.progressBar.Name = "progressBar";
      this.progressBar.Size = new System.Drawing.Size(145, 17);
      this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
      this.progressBar.TabIndex = 7;
      this.progressBar.Visible = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 138);
      this.Controls.Add(this.progressBar);
      this.Controls.Add(this.txtFileFormats);
      this.Controls.Add(this.cbSubFolders);
      this.Controls.Add(this.txtLineCount);
      this.Controls.Add(this.btnCount);
      this.Controls.Add(this.txtSelectedFolder);
      this.Controls.Add(this.btnFolderSelector);
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

    private System.Windows.Forms.Button btnFolderSelector;
    private System.Windows.Forms.TextBox txtSelectedFolder;
    private System.Windows.Forms.Button btnCount;
    private System.Windows.Forms.Label txtLineCount;
    private System.Windows.Forms.CheckBox cbSubFolders;
    private System.Windows.Forms.TextBox txtFileFormats;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.ProgressBar progressBar;
  }
}

