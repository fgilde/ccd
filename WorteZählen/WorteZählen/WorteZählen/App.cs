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
            string text = Text_holen();
            string[] stopwörter = dateiZugriff.Stopwörter_laden();
            var ergebnis = WortZähler.Zähle_Wörter(text, stopwörter);
            dialog.Zeige_Ergebnis(ergebnis, cli.Index_gewünscht);
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