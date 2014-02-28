using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IvanZ.Traktor;
using System.IO.Compression;
using System.IO;

namespace TraktorPlaylistExporter.Web.Commands
{
    public class CollectionToM3uExporter
    {
        private readonly Collection _collection;

        public CollectionToM3uExporter(Collection collection)
        {
            if (collection == null)
                throw new ArgumentNullException("collection", "collection is null.");

            _collection = collection;
        }

        public void Export(Stream outputStream)
        {
            using (ZipArchive zip = new ZipArchive(outputStream, ZipArchiveMode.Create, true)) {
                ExportFolder(_collection.RootFolder, "TraktorExporter", zip);
            }
        }

        private void ExportFolder(Folder folder, string rootPath, ZipArchive zip)
        {
            string folderPath;

            if (folder.IsRoot) {
                folderPath = rootPath;
            } else {
                folderPath = String.Format("{0}/{1}", rootPath, folder.Name);
            }

            foreach (Playlist playlist in folder.Playlists) {
                string playlistFilePath = String.Format("{0}/{1}.m3u", folderPath, playlist.Name);

                ZipArchiveEntry entry = zip.CreateEntry(playlistFilePath);

                using (StreamWriter playlistFileWriter = new StreamWriter(entry.Open())) {
                    foreach (Track track in playlist.Tracks)
                        playlistFileWriter.WriteLine(track.FilePath);
                }
            }
            foreach (Folder subFolder in folder.Folders) {
                string subFolderPath;

                if (folder.IsRoot)
                    subFolderPath = rootPath;
                else
                    subFolderPath = folderPath;

                ExportFolder(subFolder, subFolderPath, zip);
            }
        }

    }
}