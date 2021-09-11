using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mon_Projet_Telethon
{
    public partial class Accueil : Form
    {
        ToolTip toolTip1 = new ToolTip();
      
        public Accueil()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuProjet_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnDonateur_Click(object sender, EventArgs e)
        {
            Commanditaire commanditaire = new Commanditaire();
            Accueil informations = new Accueil();
           
           

           /* donateur.Visible = true;
            donateur.Activate();
            commanditaire.Hide();
            informations.Hide();*/
        }

        private void btnDon_Click(object sender, EventArgs e)
        {
            Donateur don = new Donateur();
            don.MdiParent = this;
            don.Show();
        }

        private void btnCom_Click(object sender, EventArgs e)
        {
            Accueil informations = new Accueil();
            Commanditaire commanditaire = new Commanditaire();
            commanditaire.MdiParent = this;
          //  commanditaire.Show();

           
          
            commanditaire.Visible = true;
            commanditaire.Activate();
           
            informations.Hide();
        }

        private void btnPrix_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAccuueil_Click(object sender, EventArgs e)
        {
            Accueil informations = new Accueil();
            informations.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
          
           
        }

        private void Informations_Load(object sender, EventArgs e)
        {

        }

        private void btnDon_Click_1(object sender, EventArgs e)
        {
            Donateur don = new Donateur();
            don.MdiParent = this;
            don.Show();
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Apropos apropos = new Apropos();
            apropos.MdiParent = this;
            apropos.Show();
           
        }
    }
}
