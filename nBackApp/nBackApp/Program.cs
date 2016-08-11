using System;
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
            nBack.Ende = (abbruch, auswertung) =>
            {
                if (!abbruch)
                {
                    spielForm.Close();
                    MessageBox.Show($"Auswertung: Fehler:{auswertung.Fehler} Korrekt: {auswertung.Prozent} %");
                }
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
