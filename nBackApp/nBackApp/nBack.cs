using System;
using System.Timers;

namespace nBackApp
{
    public class nBack
    {
        public Action<Spielzug> NächsterSpielzug;
        public Action<bool> Ende;
        private SpielStand spielStand;
        private Reizspeicher reizspeicher;

        public void Spielen(Profil profil)
        {
            var reize = ReizMacher.ReizeBerechnen(profil.Anzahl, profil.N);
            spielStand = new SpielStand(profil);
            reizspeicher = new Reizspeicher(reize);
            Ziehen();
        }


        public void Erkennen()
        {
            spielStand.AntwortMerken('J');
            Ziehen();
        }

        public void Überspringen()
        {
            spielStand.AntwortMerken('N');
            Ziehen();
        }

        public void Abbrechen()
        {
            SpielBeenden(true);
        }

        private void Ziehen()
        {
            reizspeicher.Nächster(
                c =>
                {
                    var spielzug = new Spielzug
                    {
                        Anzahl = reizspeicher.Anzahl,
                        Index = reizspeicher.Index + 1,
                        Reiz = c.ToString(),
                        Dauer = spielStand.Profil.Dauer
                    };
                    NächsterSpielzug(spielzug);
                },
                () => SpielBeenden());
        }

        private void SpielBeenden(bool abbruch = false)
        {
            new Protokollant().Schreiben(spielStand, reizspeicher);
            Ende(abbruch);
        }
    }
}