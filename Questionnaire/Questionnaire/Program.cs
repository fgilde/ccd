using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Questionnaire.Adapter.Dialoge;

namespace Questionnaire
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var fragebogen = new Fragebogen();
            var fragen = fragebogen.Lese_Fragebogen();


            var questionnaireForm = new QuestionnaireForm(fragen);


            Application.Run(questionnaireForm);
        }
    }
}
