using System;
using System.Windows.Forms;
using Questionnaire.Daten;

namespace Questionnaire.Adapter.Dialoge
{
    public partial class QuestionControl : UserControl
    {
        private readonly Frage frage;
        private readonly Action<Frage, Antwort> antwort_gegeben;

        public QuestionControl(Frage frage, Action<Frage, Antwort> antwort_gegeben)
        {
            InitializeComponent();

            this.frage = frage;
            this.antwort_gegeben = antwort_gegeben;
            Erstelle_Frage_UI(frage);
        }

        private void Erstelle_Frage_UI(Frage frage)
        {
            labelQuestion.Text = frage.Text;
            foreach (Antwort antwort in frage.Antworten)
            {
                var radioButton = new RadioButton {Text = antwort.Text, Checked = antwort.Ausgewählt, Tag = antwort};
                radioButton.CheckedChanged += RadioButton_CheckedChanged;
                panelScroll.Controls.Add(radioButton);
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = (RadioButton)sender;
            if (radioButton.Checked)
                antwort_gegeben(frage, (Antwort)radioButton.Tag);
        }
    }
}
