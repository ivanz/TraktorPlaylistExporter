namespace TraktorPlaylistExporter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._browseTraktorLibraryFolderButton = new System.Windows.Forms.Button();
            this._browseOutputFolderButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._exportButton = new System.Windows.Forms.Button();
            this._outputTextBox = new System.Windows.Forms.TextBox();
            this._selectedTraktorLibraryFolderLabel = new System.Windows.Forms.Label();
            this._exportPathLabel = new System.Windows.Forms.Label();
            this._urlToAppLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Export to this folder:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Your Traktor libary folder:";
            // 
            // _browseTraktorLibraryFolderButton
            // 
            this._browseTraktorLibraryFolderButton.Location = new System.Drawing.Point(219, 63);
            this._browseTraktorLibraryFolderButton.Name = "_browseTraktorLibraryFolderButton";
            this._browseTraktorLibraryFolderButton.Size = new System.Drawing.Size(115, 37);
            this._browseTraktorLibraryFolderButton.TabIndex = 12;
            this._browseTraktorLibraryFolderButton.Text = "Browse";
            this._browseTraktorLibraryFolderButton.UseVisualStyleBackColor = true;
            this._browseTraktorLibraryFolderButton.Click += new System.EventHandler(this._browseTraktorLibraryFolderButton_Click);
            // 
            // _browseOutputFolderButton
            // 
            this._browseOutputFolderButton.Location = new System.Drawing.Point(219, 129);
            this._browseOutputFolderButton.Name = "_browseOutputFolderButton";
            this._browseOutputFolderButton.Size = new System.Drawing.Size(115, 37);
            this._browseOutputFolderButton.TabIndex = 13;
            this._browseOutputFolderButton.Text = "Browse";
            this._browseOutputFolderButton.UseVisualStyleBackColor = true;
            this._browseOutputFolderButton.Click += new System.EventHandler(this._browseOutputFolderButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(420, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Traktor Playlist Exporter 0.1 by Ivan Zlatev";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "1.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "2.";
            // 
            // _exportButton
            // 
            this._exportButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._exportButton.Location = new System.Drawing.Point(12, 190);
            this._exportButton.Name = "_exportButton";
            this._exportButton.Size = new System.Drawing.Size(700, 42);
            this._exportButton.TabIndex = 23;
            this._exportButton.Text = "3. Go!";
            this._exportButton.UseVisualStyleBackColor = true;
            this._exportButton.Click += new System.EventHandler(this._exportButton_Click);
            // 
            // _outputTextBox
            // 
            this._outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._outputTextBox.Location = new System.Drawing.Point(12, 247);
            this._outputTextBox.Multiline = true;
            this._outputTextBox.Name = "_outputTextBox";
            this._outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._outputTextBox.Size = new System.Drawing.Size(700, 79);
            this._outputTextBox.TabIndex = 24;
            // 
            // _selectedTraktorLibraryFolderLabel
            // 
            this._selectedTraktorLibraryFolderLabel.AutoSize = true;
            this._selectedTraktorLibraryFolderLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this._selectedTraktorLibraryFolderLabel.Location = new System.Drawing.Point(360, 73);
            this._selectedTraktorLibraryFolderLabel.Name = "_selectedTraktorLibraryFolderLabel";
            this._selectedTraktorLibraryFolderLabel.Size = new System.Drawing.Size(127, 17);
            this._selectedTraktorLibraryFolderLabel.TabIndex = 25;
            this._selectedTraktorLibraryFolderLabel.Text = "No folder selected.";
            // 
            // _exportPathLabel
            // 
            this._exportPathLabel.AutoSize = true;
            this._exportPathLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this._exportPathLabel.Location = new System.Drawing.Point(360, 139);
            this._exportPathLabel.Name = "_exportPathLabel";
            this._exportPathLabel.Size = new System.Drawing.Size(127, 17);
            this._exportPathLabel.TabIndex = 26;
            this._exportPathLabel.Text = "No folder selected.";
            // 
            // _urlToAppLabel
            // 
            this._urlToAppLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._urlToAppLabel.AutoSize = true;
            this._urlToAppLabel.Location = new System.Drawing.Point(408, 348);
            this._urlToAppLabel.Name = "_urlToAppLabel";
            this._urlToAppLabel.Size = new System.Drawing.Size(304, 17);
            this._urlToAppLabel.TabIndex = 27;
            this._urlToAppLabel.TabStop = true;
            this._urlToAppLabel.Text = "https://github.com/ivanz/TraktorPlaylistExporter";
            this._urlToAppLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._urlToAppLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 374);
            this.Controls.Add(this._urlToAppLabel);
            this.Controls.Add(this._exportPathLabel);
            this.Controls.Add(this._selectedTraktorLibraryFolderLabel);
            this.Controls.Add(this._outputTextBox);
            this.Controls.Add(this._exportButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._browseTraktorLibraryFolderButton);
            this.Controls.Add(this._browseOutputFolderButton);
            this.Name = "MainForm";
            this.Text = "Traktor Playlist Exporter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _browseTraktorLibraryFolderButton;
        private System.Windows.Forms.Button _browseOutputFolderButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button _exportButton;
        private System.Windows.Forms.TextBox _outputTextBox;
        private System.Windows.Forms.Label _selectedTraktorLibraryFolderLabel;
        private System.Windows.Forms.Label _exportPathLabel;
        private System.Windows.Forms.LinkLabel _urlToAppLabel;
    }
}

