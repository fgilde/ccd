using System;
using Questionnaire.Daten;

namespace Questionnaire.Adapter.Dialoge
{
    public partial class QuestionnaireForm : System.Windows.Forms.Form
    {
        private readonly Action auswertung_angefordert;
        private readonly Action<Frage, Antwort> antwort_gegeben;

        public QuestionnaireForm(Frage[] fragen, Action<Frage, Antwort> antwort_gegeben, Action auswertung_angefordert)
        {
            InitializeComponent();
            this.antwort_gegeben = antwort_gegeben;
            this.auswertung_angefordert = auswertung_angefordert;
            Erstelle_Fragen_UI(fragen);
        }

        private void buttonShowScore_Click(object sender, EventArgs e)
        {
            auswertung_angefordert();
        }
        
        private void Erstelle_Fragen_UI(Frage[] fragen)
        {
            foreach (var frage in fragen)
            {
                var qc = new QuestionControl(frage, antwort_gegeben);
                panelScroll.Controls.Add(qc);
            }
        }
    }
}
