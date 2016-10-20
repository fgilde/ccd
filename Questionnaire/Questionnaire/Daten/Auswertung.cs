using System;
using System.Linq;

namespace Questionnaire.Daten
{
    /// <summary>
    /// Da sehr trivial, haben wir uns die Logik-Klasse Auswerter geschenkt und nutzen nur berechnete Eigenschaften.
    /// </summary>

    public class Auswertung 
    {
        private readonly Frage[] fragen;

        public int Korrekte_Antworten => fragen.Count(f => f.Richitg_Beantwortet);
        public int Fragen => fragen.Length;
        public double Prozent => (double)Korrekte_Antworten / Fragen;

        public Auswertung(Frage[] fragen)
        {
            this.fragen = fragen;
        }
    }
}
