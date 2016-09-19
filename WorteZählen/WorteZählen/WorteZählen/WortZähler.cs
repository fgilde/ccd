using System;
using System.Linq;

namespace WorteZ�hlen
{
    public class WortZ�hler
    {
        public static int Z�hle_W�rter(string text, string[] stopw�rter)
        {
            var wortKandidaten = Aufteilen_nach_Trennzeichen(text);
            var w�rter = Filter_Kandidaten(wortKandidaten, stopw�rter);
            return Worte_z�hlen(w�rter);
        }

        private static int Worte_z�hlen(string[] w�rter)
        {
            return w�rter.Length;
        }

        private static string[] Filter_Kandidaten(string[] wortKandidaten, string[] stopw�rter)
        {
            return wortKandidaten
                .Where(Ist_Wort)
                .Where(wk => !Ist_Stopwort(wk, stopw�rter))
                .ToArray();
        }

        private static string[] Aufteilen_nach_Trennzeichen(string text)
        {
            var trennzeichen = " \r\t\n!,.:;\\(){}[]/$�%<>|=*+#&@-_?\"'".ToCharArray();
            return text.Split(trennzeichen, StringSplitOptions.RemoveEmptyEntries);
        }

        private static bool Ist_Wort(string wortKandidat)
        {
            return !wortKandidat.Any(char.IsDigit);
        }

        private static bool Ist_Stopwort(string wortKandidat, string[] stopw�rter)
        {
            return stopw�rter.Any(s => s.Equals(wortKandidat, StringComparison.CurrentCultureIgnoreCase));
        }
    }
} 