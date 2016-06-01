using System.Collections.Generic;
using System.Linq;

namespace DublettenFinder
{
    public class DublettenPrüfung : IDublettenprüfung
    {
        public IEnumerable<IDublette> Sammle_Kandidaten(string pfad)
        {
            return Sammle_Kandidaten(pfad, Vergleichsmodi.Größe_und_Name);
        }

        public IEnumerable<IDublette> Sammle_Kandidaten(string pfad, Vergleichsmodi modus)
        {
            IEnumerable<Datei> datein = DateiSystem.SammleDatein(pfad);
            var kanidaten = GruppierungNachGröße(datein);
            kanidaten = GruppierungNachName(kanidaten, modus);
            return kanidaten.Where(dublette => dublette.Dateipfade.Count() > 1);
        }


        public IEnumerable<IDublette> Prüfe_Kandidaten(IEnumerable<IDublette> kandidaten)
        {
            IEnumerable<Dublette> hashDubletten = ErzeugeDublettenMitHash(kandidaten);
            IEnumerable<IDublette> ergebnis = GruppiereNachHash(hashDubletten);
            return ergebnis.Where(e => e.Dateipfade.Count() > 1);
        }

        private IEnumerable<Dublette> GruppierungNachName(IEnumerable<Dublette> kanidaten, Vergleichsmodi modus)
        {
            return modus == Vergleichsmodi.Größe_und_Name ? 
                kanidaten.SelectMany(dublette => dublette.Dateien.GroupBy(d => d.Name).Select(g => new Dublette { Dateien = g })) 
                : kanidaten;
        }

        private IEnumerable<Dublette> GruppierungNachGröße(IEnumerable<Datei> datein)
        {
             return datein.GroupBy(d => d.Size).Select(g => new Dublette(g));
        }

        private IEnumerable<IDublette> GruppiereNachHash(IEnumerable<Dublette> dubletten)
        {
            return dubletten.SelectMany(dublette => dublette.Dateien.GroupBy(d => d.MD5Hash).Select(g => new Dublette { Dateien = g }));
        }

        private IEnumerable<Dublette> ErzeugeDublettenMitHash(IEnumerable<IDublette> kandidaten)
        {
            return kandidaten.Select(dublette => new Dublette(dublette));
        }
    }
}