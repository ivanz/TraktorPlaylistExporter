using System;
using System.Collections.Generic;
using System.Linq;

namespace IvanZ.Traktor
{
    public class Track
    {
        internal Track(string filePath)
        {
            FilePath = filePath;
        }

        public string FilePath { get; private set; }
    }
}
