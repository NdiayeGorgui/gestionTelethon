using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mon_Projet_Telethon
{
    public partial class Connexion : Form
    {
        private int counter = 3;
        public Connexion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        //methode de connexion avec les informations fournies
        private void btnOk_Click(object sender, EventArgs e)
        {
            Accueil info = new Accueil();

           
             if (txtUserName.Text.Equals("téléthon 2021") && txtPassword.Text.Equals("Don@2021"))
             {

                 info.Visible = true;
                 info.Activate();
                 this.Hide();

             }
             else
             {

                 MessageBox.Show("Les informations saisies ne sont pas valides.",
                 "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);

                 // Nous supprimons tout le texte saisie et nous donnons le focus à txtuserName

                 txtUserName.Text = String.Empty;
                 txtPassword.Text = String.Empty;
                 txtUserName.Focus();

                 counter--;
                 if (counter == 0)
                     Application.Exit();
             }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
