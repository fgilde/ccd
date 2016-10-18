using System;
using System.Linq;

namespace Questionnaire.Adapter.Dialoge
{
    public partial class QuestionnaireForm : System.Windows.Forms.Form
    {
        public QuestionnaireForm()
        {
            InitializeComponent();
        }

        private void buttonShowScore_Click(object sender, EventArgs e)
        {
            BuildQuestion();
        }
        
        private void BuildQuestion()
        {
            foreach (var idx in Enumerable.Range(0, 5))
            {
                var qc = new QuestionControl($"quest {idx}?", Enumerable.Repeat("answer", idx).ToArray());
                panelScroll.Controls.Add(qc);
            }
        }
    }
}
