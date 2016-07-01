using System;
using System.Collections.Generic;
using System.Linq;

namespace DublettenFinder
{

    public class Dublette : IDublette
    {
        public Dublette()
        {}

        /// <summary>Initialisiert eine neue Instanz der <see cref="T:System.Object" />-Klasse.</summary>
        public Dublette(IEnumerable<Datei> dateien)
        {
            Dateien = dateien;
        }

        public Dublette(IDublette dublette )
        {
            Dateien = dublette.Dateipfade.Select(s => new Datei(s));
        }

        public IEnumerable<Datei> Dateien { get; set; }

        public IEnumerable<string> Dateipfade => Dateien.Select(d => d.Pfad);
    }
}
