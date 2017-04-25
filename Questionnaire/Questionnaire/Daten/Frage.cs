using System;
using System.Linq;

namespace Questionnaire.Daten
{
    public class Frage
    {
        public string Text { get; set; }
        public Antwort[] Antworten { get; set; }
        public bool Richtig_Beantwortet => Antworten.Any(a => a.Ausgewählt && a.Richtig);
    }
}