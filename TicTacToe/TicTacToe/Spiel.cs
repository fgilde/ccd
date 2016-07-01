using System;

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
            return new SpielStand {Meldung = "Neu", Spielfeld = spielfeld };
        }

        public SpielStand Ziehen(int koordinate)
        {
            ZelleBelegen(koordinate);
            SpielerWechsel();
            return SpielstandBerechnen();
        }

        private SpielStand SpielstandBerechnen()
        {
            return new SpielStand {Spielfeld = spielfeld};
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