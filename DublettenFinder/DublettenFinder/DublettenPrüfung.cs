using System.Collections.Generic;

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
            throw new System.NotImplementedException();
        }

        public IEnumerable<IDublette> Prüfe_Kandidaten(IEnumerable<IDublette> kandidaten)
        {
            throw new System.NotImplementedException();
        }
    }
}