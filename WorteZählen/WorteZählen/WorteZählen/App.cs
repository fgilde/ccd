namespace WorteZ�hlen
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
            string[] stopw�rter = dateiZugriff.Stopw�rter_laden();
            var ergebnis = WortZ�hler.Z�hle_W�rter(text, stopw�rter);
            dialog.Zeige_Ergebnis(ergebnis, cli.Index_gew�nscht);
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