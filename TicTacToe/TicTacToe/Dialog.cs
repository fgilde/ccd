using System;
using System.Linq;

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
            Menu(
                NeuesSpielAngefordert,
                zweiDKoordinate => SpielzugAuflösen(zweiDKoordinate, 
                                        SpielzugAngefordert));
        }

        private void Menu( Action neuErkannt, Action<string> koordinateErkannt)
        {
            while (true)
            {
                Console.Write("Kommando:");
                var eingabe = Console.ReadLine();

                if (eingabe == "exit") break;

                if (eingabe == "neu")
                    neuErkannt();
                else
                    koordinateErkannt(eingabe);
            }
        }

        private void SpielzugAuflösen(string zweiDKoordinate, Action<int> gültigeKoordinate)
        {
            var gültige2DKoordinaten = new [] { "A0", "B0", "C0", "A1", "B1", "C1", "A2", "B2", "C2" };
            var index = Array.IndexOf(gültige2DKoordinaten, zweiDKoordinate.ToUpper());
            if (index >= 0)
                gültigeKoordinate(index);
        }

        public void Ausgeben(SpielStand spielStand)
        {
            Console.WriteLine($" A B C\n" +
                              $"0{spielStand.Spielfeld[0]}|{spielStand.Spielfeld[1]}|{spielStand.Spielfeld[2]}\n" +
                              " -+-+-\n" +
                              $"1{spielStand.Spielfeld[3]}|{spielStand.Spielfeld[4]}|{spielStand.Spielfeld[5]}\n" +
                              " -+-+-\n" +
                              $"2{spielStand.Spielfeld[6]}|{spielStand.Spielfeld[7]}|{spielStand.Spielfeld[8]}");
            Console.WriteLine(spielStand.Meldung);
        }
        
    }
}