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
    public partial class VoegPersoonToe : Form
    {
        public VoegPersoonToe()
        {
            InitializeComponent();
        }
        public string naam;
        public DateTime geboorteDatum;
        public string geslacht;
        
        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VoegPersoonToe_Load(object sender, EventArgs e)
        {
            cbGeslacht.Items.Add("Man");
            cbGeslacht.Items.Add("Vrouw");
        }

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            if(tbFamilieNaam.Text!="" && tbVoornaam.Text!="" && cbGeslacht.SelectedIndex>-1 && dtGeboorteDatum.Value<DateTime.Now)
            {
                naam = tbFamilieNaam.Text + " " + tbVoornaam.Text;
                geboorteDatum = dtGeboorteDatum.Value;
                geslacht = cbGeslacht.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


    }
}
