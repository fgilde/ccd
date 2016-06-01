﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DublettenFinder
{
    public class Dublette : IDublette
    {
        public IEnumerable<string> Dateipfade { get; set; }
    }

    public class HashDublette : IDublette
    {
        public HashDublette()
        {
            Dateien = new List<Datei>();
        }

        public HashDublette(IDublette dublette )
        {
            Dateien = new List<Datei>(dublette.Dateipfade.Select(s => new Datei(new FileInfo(s))));
        }

        public IEnumerable<Datei> Dateien { get; set; }

        public IEnumerable<string> Dateipfade => Dateien.Select(d => d.Pfad);
    }
}
