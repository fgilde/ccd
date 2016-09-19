using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WorteZählen
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new App();
            app.Run(args);
        }
    }

    internal class App
    {
        private Dialog dialog;
        private DateiZugriff dateiZugriff;

        public App()
        {
            dialog = new Dialog();
            dateiZugriff = new DateiZugriff();
        }

        public void Run(string[] args)
        {
            string text = Text_holen(args);
            string[] stopwörter = dateiZugriff.Stopwörter_laden();
            int n = WortZähler.Zähle_Wörter(text, stopwörter);
            dialog.Zeige_Anzahl_Wörter(n);
        }

        private string Text_holen(string[] args)
        {
            string text = string.Empty;
            var cli = new Cli();
            cli.Pfad_lesen(args, 
                pfad => text = dateiZugriff.Textdatei_lesen(pfad), 
                () => text = dialog.Fordere_Eingabe());

            return text;
        }
    }
}
