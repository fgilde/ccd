using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe;

namespace TicTacToeForms
{
    public partial class SpielBrett : System.Windows.Forms.Form
    {
        private Button[] buttons;

        public Action NeuesSpielAngefordert { get; set; }
        public Action<int> SpielzugAngefordert { get; set; }

        public SpielBrett()
        {
            InitializeComponent();
            buttons = new[] {button0, button1, button2, button3, button4, button5, button6, button7, button8};
        }

        public void Ausgeben(SpielStand spielStand)
        {
            for (int i = 0; i < spielStand.Spielfeld.Length; i++)
                buttons[i].Text = spielStand.Spielfeld[i].ToString();
            labelMeldung.Text = spielStand.Meldung;
            buttons.ToList().ForEach(button => button.Enabled = !spielStand.SpielVorbei);
        }

        private void OnZelleKlick(object sender, EventArgs e)
        {
            SpielzugAngefordert(Array.IndexOf(buttons, sender));
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            NeuesSpielAngefordert();
        }
    }
}
