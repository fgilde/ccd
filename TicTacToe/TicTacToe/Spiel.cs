using System;
using System.Diagnostics.Eventing.Reader;
using System.Linq;

namespace TicTacToe
{
    public class Spiel
    {
        private char[] spielfeld;
        private char spieler;


        public SpielStand Neu()
        {
            spielfeld = new[] {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '};
            spieler = 'X';
            return SpielstandBerechnen();
        }

        public SpielStand Ziehen(int koordinate)
        {
            var meldung = "";
            SpielZugPrüfen(koordinate,
                () =>
                {
                    ZelleBelegen(koordinate);
                    SpielendePrüfen(
                        (s) => meldung = s,
                        () =>
                        {
                            SpielerWechsel();
                        });
                
                },
                s => meldung = s );
            
            return SpielstandBerechnen(meldung);
        }

        private void SpielendePrüfen(Action<string> endeErkannt, Action weiter)
        {
            GewonnenPrüfen(
                endeErkannt,
                () => UnentschiedenPrüfen( endeErkannt, weiter));

        }

        private void UnentschiedenPrüfen(Action <string> endeErkannt, Action weiter)
        {
            if (spielfeld.Any(c => c == ' '))
                weiter();
            else endeErkannt("Unentschieden");
        }

        private void GewonnenPrüfen(Action<string> endeErkannt, Action weiter)
        {
            if (spielfeld[4] != ' ')
                endeErkannt("Gewonnen");
            else
                weiter();
        }

        private void SpielZugPrüfen(int koordinate,Action gueltigerZug, Action<string> ungueltigerZug)
        {
            if (spielfeld[koordinate] == ' ')
                gueltigerZug();
            else
                ungueltigerZug("Zelle bereits belegt");
        }

        private SpielStand SpielstandBerechnen(string meldung = "")
        {
            return new SpielStand {Meldung = meldung, Spielfeld = spielfeld};
        }

        private void SpielerWechsel()
        {
            spieler = spieler == 'X' ? 'O' : 'X';
        }

        private void ZelleBelegen(int koordinate)
        {
            spielfeld[koordinate] = spieler;
        }
    }
}