using System;
using System.Diagnostics.Eventing.Reader;

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
                    SpielerWechsel();               
                },
                s => meldung = s );
            
            return SpielstandBerechnen(meldung);
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