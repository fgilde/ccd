using System;

namespace TicTacToe
{
    public class Dialog
    {
        public Action NeuesSpielAngefordert { get; set; }
        public Action<int> SpielzugAngefordert { get; set; }

        public void Show(SpielStand spielstand)
        {
            Ausgeben(spielstand);
            BefehleErwarten();
        }

        private void BefehleErwarten()
        {
            while (true)
            {
                Console.Write("Kommando:");
                var eingabe = Console.ReadLine();

                if (eingabe == "exit") break;

                if (eingabe == "neu")
                    NeuesSpielAngefordert();
                else
                    SpielzugAngefordert(0);
            }
        }

        public void Ausgeben(SpielStand spielStand)
        {
            Console.WriteLine(spielStand.Meldung);
        }
        
    }
}