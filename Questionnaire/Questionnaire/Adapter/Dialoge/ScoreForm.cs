using System;
using Questionnaire.Daten;

namespace Questionnaire.Adapter.Dialoge
{
    public partial class ScoreForm : System.Windows.Forms.Form
    {
        public ScoreForm(Auswertung auswertung)
        {
            InitializeComponent();
            Erstelle_Auswertung_UI(auswertung);
        }

        private void Erstelle_Auswertung_UI(Auswertung auswertung)
        {
            labelScore.Text = $@"{auswertung.Korrekte_Antworten} out of {auswertung.Fragen_Anzahl} questions answered correctly ({auswertung.Prozent:P2})";
            foreach (Frage frage in auswertung.Fragen)
            {
                ScoreControl scoreControl = new ScoreControl(frage);
                panelScroll.Controls.Add(scoreControl);
            }
        }
    }
}
