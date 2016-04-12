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

        private static IEnumerable<string> GeneriereOutput(IEnumerable<string[]> tabelle, int[] maxSpaltenlänge)
        {
            throw new NotImplementedException();
        }

        private static int[] MaxSpaltenlängen(IEnumerable<string[]> tabelle)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<string[]> ZerlegeInSpalten(IEnumerable<string> csvZeilen)
        {
            return csvZeilen.Select(z => z.Split(';'));
        }
    }
}
