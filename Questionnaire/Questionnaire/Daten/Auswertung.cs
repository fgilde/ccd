using System;
using System.Linq;

namespace Questionnaire.Daten
{
    /// <summary>
    /// Da sehr trivial, haben wir uns die Logik-Klasse Auswerter geschenkt und nutzen nur berechnete Eigenschaften.
    /// </summary>

    public class Auswertung 
    {
        public Frage[] Fragen { get; private set; }
        public int Korrekte_Antworten => Fragen.Count(f => f.Richitg_Beantwortet);
        public int Fragen_Anzahl => Fragen.Length;
        public double Prozent => (double)Korrekte_Antworten / Fragen_Anzahl;

        public Auswertung(Frage[] fragen)
        {
            this.Fragen = fragen;
        }
    }
}
