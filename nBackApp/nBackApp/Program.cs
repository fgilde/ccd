using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nBackApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var nBack = new nBack();
            var spielForm = new SpielForm();
            spielForm.Abgebrochen = nBack.Abbrechen;
            spielForm.Erkannt = nBack.Erkennen;
            spielForm.Übersprungen = nBack.Überspringen;

            nBack.NächsterSpielzug = spielForm.NeuerSpielzug;
            nBack.Ende = abbruch =>
            {
                if(!abbruch)
                    spielForm.Close();
            };

            var profilForm = new ProfilForm();
            profilForm.Spielen = p =>
            {
                nBack.Spielen(p);
                spielForm.ShowDialog(profilForm);
            };
            
            Application.Run(profilForm);
        }
    }
}
