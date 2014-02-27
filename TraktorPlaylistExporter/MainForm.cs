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
using IvanZ.Traktor;
using TraktorPlaylistExporter.Utils;

namespace TraktorPlaylistExporter
{
    public partial class MainForm : Form, IProgressObserver
    {
        private const int PATH_MAX_LENGTH = 25;
        private string _pathToTraktor;
        private string _exportPath;

        public MainForm()
        {
            InitializeComponent();

            PathToTraktor = Collection.Find();
            ExportPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "Traktor Playlist Export");
        }

        private void AppendOutput(string text)
        {
            _outputTextBox.Text = text + Environment.NewLine + _outputTextBox.Text;
        }

        private string PathToTraktor
        {
            get { return _pathToTraktor; }
            set {
                _pathToTraktor = value;
                _selectedTraktorLibraryFolderLabel.Text = value != null ? value.Ellipsize(PATH_MAX_LENGTH) : String.Empty;
                AppendOutput("Selected Traktor collection folder:" + value);
            }
        }

        private string ExportPath
        {
            get { return _exportPath; }
            set {
                _exportPath = value;
                _exportPathLabel.Text = value != null ? value.Ellipsize(PATH_MAX_LENGTH) : String.Empty;
                AppendOutput("Selected export folder to Traktor collection:" + value);
            }
        }

        private void _browseTraktorLibraryFolderButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog()) {
                if (folderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    PathToTraktor = folderDialog.SelectedPath;
            }
        }

        private void _exportButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(PathToTraktor) || String.IsNullOrWhiteSpace(ExportPath)) {
                MessageBox.Show("Please select both the path to the Traktor collection folder and export folder");
                return;
            }

            CollectionToM3uExporter exporter = new CollectionToM3uExporter(new Collection(PathToTraktor)) {
                ProgressObserver = this
            };
            exporter.Export(ExportPath);
        }

        #region IProressObserver

        public void OnOperationStarted(string text)
        {
            Invoke((Action)(() => AppendOutput(text)));
        }

        public void OnStepCompleted(string text)
        {
            Invoke((Action)(() => AppendOutput(text)));
        }

        public void OnOperationEnded(string text)
        {
            Invoke((Action)(() => AppendOutput(text)));
        }

        public void OnError(string error)
        {
            Invoke((Action)(() => AppendOutput("[ERROR] " + error)));
        }

        #endregion

        private void _urlToAppLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(((LinkLabel) sender).Text);
        }

    }
}
