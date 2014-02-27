using System;
using System.Collections.Generic;
using System.Linq;

namespace IvanZ.Traktor
{
    public class Folder
    {
        internal Folder(string name)
        {
            Name = name;
            Folders = new List<Folder>();
            Playlists = new List<Playlist>();
        }

        public string Name { get; private set; }
        public List<Folder> Folders { get; set; }
        public List<Playlist> Playlists { get; set; }

        public bool IsRoot {
            get { return String.Equals(Name, "$ROOT", StringComparison.InvariantCultureIgnoreCase); }
        }
    }
}
