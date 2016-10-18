using System;

namespace Questionnaire.Daten
{
    public class Frage
    {
        public string Text { get; set; }
        public Antwort[] Antworten { get; set; }
    }
}