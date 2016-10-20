using System;
using System.Windows.Forms;
using Questionnaire.Adapter.Dialoge;
using Questionnaire.Daten;

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

            var app = new App();
            app.Run();
        }
    }
}
