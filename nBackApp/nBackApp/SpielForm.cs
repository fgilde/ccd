using System;
using System.Runtime.InteropServices;
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
            timerCountdown.Stop();
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

        #region Some Progressbar Hacks damit Sie auch ans Ende läuft ;)
        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.Load"/> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data. </param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SendMessage(progressBarReizDauer.Handle,
               0x400 + 16, //WM_USER + PBM_SETSTATE
               0x0003, //PBST_PAUSED
               0);
        }

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        static extern uint SendMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);

        #endregion
    }
}
