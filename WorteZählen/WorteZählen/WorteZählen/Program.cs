using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorteZählen
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            var dialog = new Dialog();
            var dateiZugriff = new DateiZugriff();

            string text = dialog.Fordere_Eingabe();
            string[] stopwörter = dateiZugriff.Stopwörter_laden();
            int n = WortZähler.Zähle_Wörter(text, stopwörter);
            dialog.Zeige_Anzahl_Wörter(n);
        }
    }
}
