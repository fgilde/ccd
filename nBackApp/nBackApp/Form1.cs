using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nBackApp
{
    public partial class SpielForm : Form
    {
        public Action Abgebrochen;
        public Action Erkannt;
        public Action Übersprungen;

        public SpielForm()
        {
            InitializeComponent();
        }

        public void NeuerSpielzug(Spielzug spielzug)
        {
            labelFortschritt.Text = $"{spielzug.Index} von {spielzug.Anzahl}";
            labelReiz.Text = spielzug.Reiz;
            progressBarReizFortschritt.Maximum = spielzug.Anzahl;
            progressBarReizFortschritt.Value = spielzug.Index;
            progressBarReizDauer.Maximum = spielzug.Dauer;
            progressBarReizDauer.Value = 0;
            timerTimeout.Interval = spielzug.Dauer;

            timerCountdown.Start();
            timerTimeout.Start();
        }

        private void buttonErkannt_Click(object sender, EventArgs e)
        {
            timerTimeout.Stop();
            Erkannt();
        }

        private void buttonÜberspringen_Click(object sender, EventArgs e)
        {
            timerTimeout.Stop();
            Übersprungen();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.Closed"/> event.
        /// </summary>
        /// <param name="e">The <see cref="T:System.EventArgs"/> that contains the event data. </param>
        protected override void OnClosed(EventArgs e)
        {
            Abgebrochen();
            base.OnClosed(e);
        }

        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            progressBarReizDauer.Value += timerCountdown.Interval;
        }

        private void timerTimeout_Tick(object sender, EventArgs e)
        {
            timerTimeout.Stop();
            Übersprungen();
        }
    }
}
