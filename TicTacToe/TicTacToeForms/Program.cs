using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe;

namespace TicTacToeForms
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

            // Build
            var spielBrett = new SpielBrett();
            var spiel = new Spiel();

            // Bind
            spielBrett.NeuesSpielAngefordert = () =>
            {
                var spielStand = spiel.Neu();
                spielBrett.Ausgeben(spielStand);
            };
            spielBrett.SpielzugAngefordert = koordinate =>
            {
                var spielStand = spiel.Ziehen(koordinate);
                spielBrett.Ausgeben(spielStand);
            };

            // Run
            spiel.Neu();
            Application.Run(spielBrett);
        }
    }
}
