using System;
using System.Linq;

namespace WorteZ�hlen
{
    internal class Cli
    {
        private readonly string[] args;
        public bool Index_gew�nscht => args.Any(a => a.Equals("-index", StringComparison.CurrentCultureIgnoreCase));

        public Cli(string[] args)
        {
            this.args = args;
        }

        public void Pfad_lesen(Action<string> pfad_gefunden, Action kein_Pfad_gefunden)
        {
            var pfad = args.FirstOrDefault(a => !a.StartsWith("-"));
            if (pfad != null)
                pfad_gefunden(pfad);
            else
                kein_Pfad_gefunden();
        }
    }
}