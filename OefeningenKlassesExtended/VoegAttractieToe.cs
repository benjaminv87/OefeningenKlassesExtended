using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OefeningenKlassesExtended
{
    public partial class VoegAttractieToe : Form
    {
        public VoegAttractieToe()
        {
            InitializeComponent();
        }

        public string naam;
        public string kleur;
        public int maxAantal;
        public int minLeeftijd;

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            naam = tbNaam.Text;
            kleur = tbKleur.Text;
            maxAantal = Convert.ToInt32(numMaxAantal.Value);
            minLeeftijd =Convert.ToInt32(numMinLeeftijd.Value);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
