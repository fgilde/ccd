using System;
using System.Collections.Generic;
using System.Linq;

namespace nBackApp
{
    public class Auswertung
    {
        public int Fehler { get; private set; }
        public double Prozent { get; private set; }
         
        public Auswertung(SpielStand spielStand, Reizspeicher reizspeicher)
        {
            Fehler = Fehleranzahl_ermitteln(spielStand, reizspeicher);
            Prozent = Erfolgsquote_berechnen(reizspeicher);
        }

        private double Erfolgsquote_berechnen(Reizspeicher reizspeicher)
        {
            return (reizspeicher.Anzahl - Fehler) * 100.0 / reizspeicher.Anzahl;
        }

        private int Fehleranzahl_ermitteln(SpielStand spielStand, Reizspeicher reizspeicher)
        {
            char[] richtigenAntworten = KorrekteAntwortenErmitteln(spielStand.Profil.N, reizspeicher);
            int fehlerAnzahl = UnterschiedeZählen(richtigenAntworten, spielStand.AlleAntworten());
            return fehlerAnzahl;
        }

        private char[] KorrekteAntwortenErmitteln(int nBack, Reizspeicher reizspeicher)
        {
            List<char> korrekteAntworten = Enumerable.Repeat('N', nBack).ToList();
            for (int idx = nBack; idx < reizspeicher.Anzahl; idx++)
            {
                korrekteAntworten.Add(reizspeicher.Reize[idx - nBack] == reizspeicher.Reize[idx] ? 'J' : 'N');
            }
            return korrekteAntworten.ToArray();
        }

        private int UnterschiedeZählen(char[] richtigenAntworten, char[] alleAntworten)
        {
            return alleAntworten.Where((antwort, idx) => richtigenAntworten[idx] != antwort).Count();
        }
    }
}