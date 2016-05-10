using System.Collections.Generic;

namespace DublettenFinder
{
    interface IDublettenprüfung
    {
        IEnumerable<IDublette> Sammle_Kandidaten(string pfad);
        IEnumerable<IDublette> Sammle_Kandidaten(string pfad, Vergleichsmodi modus);

        IEnumerable<IDublette> Prüfe_Kandidaten(IEnumerable<IDublette> kandidaten);
    }

    interface IDublette
    {
        IEnumerable<string> Dateipfade { get; }
    }

    public enum Vergleichsmodi
    {
        Größe_und_Name,
        Größe
    }
}