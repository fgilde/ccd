using System;

namespace TicTacToe
{
    public class Spiel
    {

        public SpielStand Neu()
        {
            return new SpielStand {Meldung = "Neu"};
        }

        public SpielStand Ziehen(int koordinate)
        {
            return new SpielStand {Meldung = $"Koordinate:{koordinate}"};
        }
    }
}