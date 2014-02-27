using System;
using System.Collections.Generic;
using System.Linq;

namespace IvanZ.Traktor
{
    public class Playlist
    {
        internal Playlist(string name)
        {
            Name = name;
            Tracks = new List<Track>();
        }

        public string Name { get; private set; }
        public List<Track> Tracks { get; set; }
    }
}
