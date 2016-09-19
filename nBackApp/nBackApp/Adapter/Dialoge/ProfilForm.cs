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
    public partial class ProfilForm : Form
    {
        public Action<Profil> Spielen;

        public ProfilForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            var profil = new Profil
            {
                Name = textBoxName.Text,
                N = (int)numericUpDownN.Value,
                Dauer = (int)numericUpDownDauer.Value,
                Anzahl = (int)numericUpDownReize.Value
            };
            Spielen(profil);
        }
    }
}
