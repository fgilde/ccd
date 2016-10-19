using System;
using System.Linq;
using Questionnaire.Daten;

namespace Questionnaire.Adapter.Dialoge
{
    public partial class QuestionnaireForm : System.Windows.Forms.Form
    {
        public QuestionnaireForm(Frage[] fragen)
        {
            InitializeComponent();
            Erstelle_Fragen_UI(fragen);
        }

        private void buttonShowScore_Click(object sender, EventArgs e)
        {
        }
        
        private void Erstelle_Fragen_UI(Frage[] fragen)
        {
            foreach (var frage in fragen)
            {
                var qc = new QuestionControl(frage);
                panelScroll.Controls.Add(qc);
            }
        }
    }
}
