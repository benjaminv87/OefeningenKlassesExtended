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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Pretpark mijnPretpark = new Pretpark();
        private void Form1_Load(object sender, EventArgs e)
        {
            mijnPretpark.Naam = "Het beste pretpark";
            lblPretparkNaam.Text = mijnPretpark.Naam;
            foreach (var item in groupBox1.Controls.OfType<Label>)
            {

            }
        }

        private void rbAttracties_CheckedChanged(object sender, EventArgs e)
        {
            lbMijnLijst.DataSource = mijnPretpark.AttractieLijst;
        }

        private void rbWerknemers_CheckedChanged(object sender, EventArgs e)
        {
            lbMijnLijst.DataSource = mijnPretpark.PersoneelsLijst;

        }

        private void UpdateLijst()
        {
            lbMijnLijst.DataSource = null;
            if (rbAttracties.Checked)
            {
                lbMijnLijst.DataSource = mijnPretpark.AttractieLijst;
            }
            else if (rbWerknemers.Checked)
            {
                lbMijnLijst.DataSource = mijnPretpark.PersoneelsLijst;
            }
        }
        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            if (rbAttracties.Checked)
            {
                mijnPretpark.AttractieLijst.RemoveAt(lbMijnLijst.SelectedIndex);
            }
            else if (rbWerknemers.Checked)
            {
                mijnPretpark.PersoneelsLijst.RemoveAt(lbMijnLijst.SelectedIndex);
            }
            UpdateLijst();
        }

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            if (rbAttracties.Checked)
            {
                Attractie nieuweAttractie = new Attractie();
                using(VoegAttractieToe voegToe = new VoegAttractieToe())
                {
                    var result = voegToe.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        nieuweAttractie.Naam = voegToe.naam;
                        nieuweAttractie.Kleur = voegToe.kleur;
                        nieuweAttractie.MaxPersonen = voegToe.maxAantal;
                        nieuweAttractie.MinLeeftijd = voegToe.minLeeftijd;
                        mijnPretpark.AttractieLijst.Add(nieuweAttractie);
                    }
                }
            }
            else if (rbWerknemers.Checked)
            {
                Werknemer nieuweWerknemer = new Werknemer();
                using (VoegPersoonToe voegToe = new VoegPersoonToe())
                {
                    var result = voegToe.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        nieuweWerknemer.Naam = voegToe.naam;
                        nieuweWerknemer.Geslacht = voegToe.geslacht;
                        nieuweWerknemer.GeboorteDatum = voegToe.geboorteDatum;
                        mijnPretpark.PersoneelsLijst.Add(nieuweWerknemer);
                    }
                }
            }
            UpdateLijst();
        }

        private void lbMijnLijst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbAttracties.Checked)
            {
                lblData1.Text = $"Naam: {mijnPretpark.AttractieLijst[lbMijnLijst.SelectedIndex].Naam}";
                lblData2.Text = $"Kleur: {mijnPretpark.AttractieLijst[lbMijnLijst.SelectedIndex].Kleur}";
                lblData3.Text = $"Minimum leeftijd: {mijnPretpark.AttractieLijst[lbMijnLijst.SelectedIndex].MinLeeftijd.ToString()}";
                lblData4.Visible = true;
                lblData4.Text = $"Maximum personen: {mijnPretpark.AttractieLijst[lbMijnLijst.SelectedIndex].MaxPersonen.ToString()}";
            }
            else if (rbWerknemers.Checked)
            {
                lblData1.Text = $"Naam: {mijnPretpark.PersoneelsLijst[lbMijnLijst.SelectedIndex].Naam }";
                lblData1.Text = $"Geboortedatum: {(mijnPretpark.PersoneelsLijst[lbMijnLijst.SelectedIndex].GeboorteDatum).ToString("dd/MM/yyyy")}";
                lblData1.Text = $"Geslacht: {mijnPretpark.PersoneelsLijst[lbMijnLijst.SelectedIndex].Geslacht }";
                lblData4.Visible = false;

            }

        }
    }
    public class Pretpark
    {
        public string Naam;
        public List<Werknemer> PersoneelsLijst = new List<Werknemer>();
        public List<Attractie> AttractieLijst = new List<Attractie>();
        public void VoegPersoonToe(Werknemer nieuweWerknemer)
        {

            PersoneelsLijst.Add(nieuweWerknemer);
        }
        public void VoegAttractieToe(Attractie nieuweAttractie)
        {
            AttractieLijst.Add(nieuweAttractie);
        }
    }
    public class Werknemer
    {

        public string Naam;
        public string Geslacht;
        public DateTime GeboorteDatum;
        public override string ToString()
        {
            return Naam;
        }
    }
    public class Attractie
    {
        public string Naam;
        public int MinLeeftijd;
        public int MaxPersonen;
        public string Kleur;
        public override string ToString()
        {
            return Naam;
        }

    }
}
