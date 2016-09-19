using System;
using System.Linq;

namespace WorteZählen
{
    public class WortZähler
    {
        public static Ergebnis Zähle_Wörter(string text, string[] stopwörter)
        {
            var wortKandidaten = Aufteilen_nach_Trennzeichen(text);
            var wörter = Filter_Kandidaten(wortKandidaten, stopwörter);
            return Worte_zählen(wörter);
        }

        private static Ergebnis Worte_zählen(string[] wörter)
        {
            return new Ergebnis
            {
                Anzahl_Wörter = wörter.Length,
                Anzahl_eindeutiger_Wörter = wörter.Distinct().Count()
            };
        }

        private static string[] Filter_Kandidaten(string[] wortKandidaten, string[] stopwörter)
        {
            return wortKandidaten
                .Where(Ist_Wort)
                .Where(wk => !Ist_Stopwort(wk, stopwörter))
                .ToArray();
        }

        private static string[] Aufteilen_nach_Trennzeichen(string text)
        {
            var trennzeichen = " \r\t\n!,.:;\\(){}[]/$€%<>|=*+#&@-_?\"'".ToCharArray();
            return text.Split(trennzeichen, StringSplitOptions.RemoveEmptyEntries);
        }

        private static bool Ist_Wort(string wortKandidat)
        {
            return !wortKandidat.Any(char.IsDigit);
        }

        private static bool Ist_Stopwort(string wortKandidat, string[] stopwörter)
        {
            return stopwörter.Any(s => s.Equals(wortKandidat, StringComparison.CurrentCultureIgnoreCase));
        }
    }
} 