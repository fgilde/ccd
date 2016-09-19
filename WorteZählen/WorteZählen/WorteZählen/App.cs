namespace WorteZählen
{
    internal class App
    {
        private readonly Dialog dialog;
        private readonly DateiZugriff dateiZugriff;
        private readonly Cli cli;

        public App()
        {
            dialog = new Dialog();
            dateiZugriff = new DateiZugriff();
            cli = new Cli();
        }

        public void Run(string[] args)
        {
            string text = Text_holen(args);
            string[] stopwörter = dateiZugriff.Stopwörter_laden();
            var ergebnis = WortZähler.Zähle_Wörter(text, stopwörter);
            dialog.Zeige_Anzahl_Wörter(ergebnis);
        }

        private string Text_holen(string[] args)
        {
            string text = string.Empty;
            cli.Pfad_lesen(args, 
                pfad => text = dateiZugriff.Textdatei_lesen(pfad), 
                () => text = dialog.Fordere_Eingabe());

            return text;
        }
    }
}