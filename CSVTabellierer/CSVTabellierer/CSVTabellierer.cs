using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVTabellierer
{
    public class CSVTabellierer
    {
        public static IEnumerable<string> Tabelliere(IEnumerable<string> CSV_zeilen)
        {
            IEnumerable<string[]> tabelle = ZerlegeInSpalten(CSV_zeilen);
            int[] maxSpaltenlängen = MaxSpaltenlängen(tabelle);
            return GeneriereOutput(tabelle, maxSpaltenlängen);
        }

        public static IEnumerable<string> GeneriereOutput(IEnumerable<string[]> tabelle, int[] maxSpaltenlänge)
        {
            throw new NotImplementedException();
        }

        public static int[] MaxSpaltenlängen(IEnumerable<string[]> tabelle)
        {
            var anzahlSpalten = ErmittleAnzahlSpalten(tabelle);
            return ErmittleMaxSpaltenLänge(tabelle, anzahlSpalten);
        }

        public static int[] ErmittleMaxSpaltenLänge(IEnumerable<string[]> tabelle, int anzahlSpalten)
        {
            var maxSpaltenLängen = new int[anzahlSpalten];
            foreach (var zeile in tabelle)
            {
                for (var i = 0; i < anzahlSpalten; i++)
                    maxSpaltenLängen[i] = Math.Max(zeile[i].Length, maxSpaltenLängen[i]);
            }
            return maxSpaltenLängen;
        }

        public static int ErmittleAnzahlSpalten(IEnumerable<string[]> tabelle)
        {
            if (tabelle.Any())
                return tabelle.First().Length;
            return 0;
        }

        public static IEnumerable<string[]> ZerlegeInSpalten(IEnumerable<string> csvZeilen)
        {
            return csvZeilen.Select(z => z.Split(';'));
        }
    }
}
