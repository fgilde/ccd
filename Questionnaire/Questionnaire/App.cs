using System;
using System.Windows.Forms;
using Questionnaire.Adapter.Dialoge;
using Questionnaire.Daten;

namespace Questionnaire
{
    public class App
    {
        public void Run()
        {
            var fragebogen = new Fragebogen();
            var fragen = fragebogen.Lese_Fragebogen();

            var questionnaireForm = new QuestionnaireForm(fragen,
                Frage_beantwortet,
                () => Auswertung_anzeigen(fragen));

            Application.Run(questionnaireForm);
        }

        private static void Frage_beantwortet(Frage frage, Antwort gewählte_Antwort)
        {
            foreach (var antwort in frage.Antworten)
                antwort.Ausgewählt = antwort == gewählte_Antwort;
        }

        private static void Auswertung_anzeigen(Frage[] fragen)
        {
            Auswertung auswertung = new Auswertung(fragen);
            new ScoreForm(auswertung).ShowDialog();
        }
    }
}
