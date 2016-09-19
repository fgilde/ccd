using System;
using System.Linq;

namespace WorteZählen
{
    internal class Cli
    {
        public void Pfad_lesen(string[] args, Action<string> pfad_gefunden, Action kein_Pfad_gefunden)
        {
            if (args.Any())
                pfad_gefunden(args.First());
            else
                kein_Pfad_gefunden();
        }
    }
}