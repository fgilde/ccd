using System;
using System.Windows.Forms;
using Questionnaire.Daten;

namespace Questionnaire.Adapter.Dialoge
{
    public partial class QuestionControl : UserControl
    {
        public QuestionControl(Frage frage)
        {
            InitializeComponent();

            labelQuestion.Text = frage.Text;
            foreach (Antwort antwort in frage.Antworten)
                panelScroll.Controls.Add(new RadioButton {Text = antwort.Text, Checked = antwort.Ausgewählt});
        }
    }
}
