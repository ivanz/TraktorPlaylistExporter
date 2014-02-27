using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace IvanZ.Traktor
{
    public class Collection
    {
        private readonly string _collectionPath;
        private readonly Lazy<Folder> _rootFolderLazy;

        public Collection(string collectionPath)
        {
            if (String.IsNullOrEmpty(collectionPath))
                throw new ArgumentException("collectionPath is null or empty.", "collectionPath");

            _collectionPath = collectionPath;
            _rootFolderLazy = new Lazy<Folder>(() => ParsePlaylists(_collectionPath));
        }

        public Folder RootFolder
        {
            get { return _rootFolderLazy.Value; }
        }


        private static Folder ParsePlaylists(string pathToCollectionFile)
        {
            // TODO: Validate existence of the collection;

            return (Folder) ParseElement(XDocument.Load(pathToCollectionFile)
                    .XPathSelectElement("/NML/PLAYLISTS/NODE"));
        }

        private static object ParseElement(XElement element)
        {
            if (element.Attribute("TYPE").Value == "FOLDER") {
                Folder folder = new Folder(element.Attribute("NAME").Value);

                foreach (var subElement in element.XPathSelectElements("SUBNODES/NODE")) {
                    object item = ParseElement(subElement);
                    if (item is Folder)
                        folder.Folders.Add((Folder) item);
                    else if (item is Playlist)
                        folder.Playlists.Add((Playlist) item);
                }

                return folder;
            } else if (element.Attribute("TYPE").Value == "PLAYLIST") {
                Playlist playlist = new Playlist(element.Attribute("NAME").Value);

                foreach (var trackElement in element.XPathSelectElements("PLAYLIST/ENTRY/PRIMARYKEY[@TYPE='TRACK']")) {
                    string traktorTrackPath = trackElement.Attribute("KEY").Value;
                    string actualTrackPath = traktorTrackPath.Replace("/:", @"\");

                    playlist.Tracks.Add(new Track(actualTrackPath));
                }

                return playlist;
            } else {
                throw new NotSupportedException(element.Attribute("TYPE").Value);
            }
        }

        public static string Find()
        {
            string niFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Native Instruments");

            if (!Directory.Exists(niFolder))
                return null;

            var pair = Directory
                .GetDirectories(niFolder)
                .Where(d => Path.GetFileName(d).StartsWith("Traktor"))
                .Select(d => new {
                    Directory = d,
                    Version = Int32.Parse(Path.GetFileName(d).Replace("Traktor ", String.Empty).Replace(".", String.Empty))
                })
                .OrderByDescending(s => s.Version)
                .FirstOrDefault();

            if (pair != null)
                return Path.Combine(pair.Directory, "collection.nml");

            return null;
        }
    }
}
