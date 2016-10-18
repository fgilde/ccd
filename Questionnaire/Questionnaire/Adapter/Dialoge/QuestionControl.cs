using System;
using System.Windows.Forms;

namespace Questionnaire.Adapter.Dialoge
{
    public partial class QuestionControl : UserControl
    {
        public QuestionControl(string question, string[] answers)
        {
            InitializeComponent();

            labelQuestion.Text = question;
            foreach (string answer in answers)
            {
                panelScroll.Controls.Add(new RadioButton {Text = answer });
            }
        }
    }
}
