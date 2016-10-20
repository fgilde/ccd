using System;
using Questionnaire.Daten;

namespace Questionnaire.Adapter.Dialoge
{
    public partial class ScoreForm : System.Windows.Forms.Form
    {
        private Auswertung auswertung;

        public ScoreForm(Auswertung auswertung)
        {
            InitializeComponent();

            labelScore.Text = $"{auswertung.Korrekte_Antworten} out of {auswertung.Fragen} questions answered correctly ({auswertung.Prozent * 100}%)";        
            this.auswertung = auswertung;
        }
    }
}
