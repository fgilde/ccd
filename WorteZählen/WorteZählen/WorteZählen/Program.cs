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
            string text = Dialog.Fordere_Eingabe();
            string[] stopwörter = DateiZugriff.Stopwörter_laden();
            int n = WortZähler.Zähle_Wörter(text, stopwörter);
            Dialog.Zeige_Anzahl_Wörter(n);
        }
    }
}
