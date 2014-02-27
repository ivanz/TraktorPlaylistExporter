using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using IvanZ.Traktor;

namespace TraktorPlaylistExporter
{

    public class CollectionToM3uExporter
    {
        private IProgressObserver _progressObserver;
        private readonly Collection _collection;

        public CollectionToM3uExporter(Collection collection)
        {
            if (collection == null)
                throw new ArgumentNullException("collection", "collection is null.");

            _collection = collection;
        }

        public IProgressObserver ProgressObserver
        {
            get { return _progressObserver ?? DummyProgressObserver.Instance; }
            set { _progressObserver = value; }
        }

        public void Export(string toFolder)
        {
            ProgressObserver.OnOperationStarted("Exporting starting...");

            try {
                if (!Directory.Exists(toFolder))
                    Directory.CreateDirectory(toFolder);
            } catch (Exception ex) {
                ProgressObserver.OnError(ex.ToString());
            }

            ExportFolder(_collection.RootFolder, toFolder);
            ProgressObserver.OnOperationStarted("ALL DONE!");
        }

        private void ExportFolder(Folder folder, string rootPath)
        {
            string folderPath;

            if (folder.IsRoot) {
                folderPath = rootPath;
            } else {
                folderPath = Path.Combine(rootPath, folder.Name);
                try {
                    ProgressObserver.OnOperationStarted("Creating folder: " + folder.Name);
                    Directory.CreateDirectory(folderPath);
                } catch(Exception ex) {
                    ProgressObserver.OnError(ex.ToString());
                }
            }

            foreach (Playlist playlist in folder.Playlists) {
                string playlistFilePath = Path.Combine(folderPath, playlist.Name + ".m3u");

                try {
                    ProgressObserver.OnOperationStarted("Exporting playlist: " + playlist.Name);

                    using (StreamWriter playlistFileWriter = File.CreateText(playlistFilePath)) {
                        foreach (Track track in playlist.Tracks)
                            playlistFileWriter.WriteLine(track.FilePath);
                    }
                } catch (Exception ex) {
                    ProgressObserver.OnError(ex.ToString());
                }
            }
            foreach (Folder subFolder in folder.Folders) {
                string subFolderPath;

                if (folder.IsRoot)
                    subFolderPath = rootPath;
                else
                    subFolderPath = folderPath;

                ExportFolder(subFolder, subFolderPath);
            }
        }

        #region DummyProgressObserver

        private class DummyProgressObserver : IProgressObserver
        {
            public static readonly DummyProgressObserver Instance = new DummyProgressObserver();

            private DummyProgressObserver()
            {
            }

            public void OnOperationStarted(string text)
            {
            }

            public void OnStepCompleted(string text)
            {
            }

            public void OnOperationEnded(string text)
            {
            }

            public void OnError(string error)
            {
            }
        }

        #endregion

    }
}