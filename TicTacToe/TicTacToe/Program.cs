using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            var dialog = new Dialog();
            var spiel = new Spiel();

            dialog.NeuesSpielAngefordert = () =>
            {
                var spielStand = spiel.Neu();
                dialog.Ausgeben(spielStand);
            };
            dialog.SpielzugAngefordert = koordinate =>
            {
                var spielStand = spiel.Ziehen(koordinate);
                dialog.Ausgeben(spielStand);
            };

            var spielstand = spiel.Neu();
            
            dialog.Show(spielstand);
        }
    }
}
