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
            
            return kanidaten.Where(k => k.Count > 1).Select(k => new Dublette
            {
                Dateipfade = new List<string>(k.Select(d => d.Pfad))
            });
        }

        private List<List<Datei>> GruppierungNachName(List<List<Datei>> kanidaten, Vergleichsmodi modus)
        {
            List<List<Datei>> result = kanidaten.ToList();
            if (modus == Vergleichsmodi.Größe_und_Name)
            {
                result = new List<List<Datei>>();
                foreach (List<Datei> grouping in kanidaten)
                    result.AddRange(grouping.GroupBy(k => k.Name).Select(g => g.ToList()));
            }
           return result;
        }

        private List<List<Datei>> GruppierungNachGröße(IEnumerable<Datei> datein)
        {
             return datein.GroupBy(d => d.Size).Select(g => new List<Datei>(g)).ToList();
        }

        public IEnumerable<IDublette> Prüfe_Kandidaten(IEnumerable<IDublette> kandidaten)
        {
            throw new System.NotImplementedException();
        }
    }
}