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
            SpielerHatGewonnen('X',
                endeErkannt, 
                () => SpielerHatGewonnen('O',
                        endeErkannt, 
                        weiter)
             );
        }

        private void SpielerHatGewonnen(char spieler, Action<string> endeErkannt, Action weiter)
        {
            var gewinnerzuege = new [] {
                new [] {0, 1, 2},
                new[] { 3, 4, 5 } ,
                new[] { 6, 7, 8 } ,
                new[] { 0, 3, 6 } ,
                new[] { 1, 4, 7 } ,
                new[] { 2, 5, 8 } ,
                new[] { 0, 4, 8 } ,
                new[] { 2, 4, 6 } };

            if (gewinnerzuege.Any(ints => ints.All(i => spielfeld[i] == spieler)))
                endeErkannt($"{spieler} hat gewonnen");
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