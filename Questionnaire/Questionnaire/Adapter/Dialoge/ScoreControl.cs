using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Questionnaire.Daten;

namespace Questionnaire.Adapter.Dialoge
{
    public partial class ScoreControl : UserControl
    {
        private Frage frage;

        public ScoreControl(Frage frage)
        {
            InitializeComponent();

            string correct_or_wrong = frage.Richtig_Beantwortet ? "correct" : "wrong";

            labelQuestion.Text = frage.Text;
            labelYourAnswer.Text = $@"Your answer '{frage.Antworten.Single(a => a.Ausgewählt).Text}' is {correct_or_wrong}";
            labelYourAnswer.ForeColor = frage.Richtig_Beantwortet ? Color.Green : Color.Red;
            labelCorrectAnswer.Visible = !frage.Richtig_Beantwortet;
            labelCorrectAnswer.Text = $@"Correct answer: '{frage.Antworten.Single(a => a.Richtig).Text}'";

        }
    }
}
