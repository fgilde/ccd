namespace WorteZählen
{
    internal class App
    {
        private readonly Dialog dialog;
        private readonly DateiZugriff dateiZugriff;
        private readonly Cli cli;

        public App(string[] args)
        {
            dialog = new Dialog();
            dateiZugriff = new DateiZugriff();
            cli = new Cli(args);
        }

        public void Run()
        {
            // -- Vorbereitung
            string text = Text_holen();
            string[] stopwörter = dateiZugriff.Stopwörter_laden();
            var dict = dateiZugriff.LeseDictionary(cli.Dict_Pfad);

            // -- Ergebnis ermitteln
            var ergebnis = WortZähler.Zähle_Wörter(text, stopwörter);
            var unbekannte_worte = Lektor.Ermittle_unbekannte_Worte(ergebnis.Eindeutige_Wörter, dict);

            // -- Ausgabe
            dialog.Zeige_Ergebnis(ergebnis, unbekannte_worte, cli.Index_gewünscht, cli.Prüfbericht_gewünscht);
        }

        private string Text_holen()
        {
            string text = string.Empty;
            cli.Pfad_lesen( 
                pfad => text = dateiZugriff.Textdatei_lesen(pfad), 
                () => text = dialog.Fordere_Eingabe());

            return text;
        }
    }
}