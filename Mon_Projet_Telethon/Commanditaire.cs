using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Ma_Biblio_De_Classe;

namespace Mon_Projet_Telethon
{
    public partial class Commanditaire : Form
    {

        Gestionaire gestionaire = new Gestionaire();
        Ma_Biblio_De_Classe.Commanditaire commanditaire = new Ma_Biblio_De_Classe.Commanditaire();

        private Commanditaire[] commanditaire2  = new Commanditaire[1];
        public Commanditaire()
        {
            InitializeComponent();
        }

        private void btnQuiterCom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //pour ajouter un commanditaire
        private void btnAjoutCom_Click(object sender, EventArgs e)
        {
            //Affiche un message d'erreur si la saisie est vide

            if (String.IsNullOrEmpty(txtIdCommanditaire.Text) 
                || String.IsNullOrEmpty(txtPrenomCom.Text)
                || String.IsNullOrEmpty(txtNomCom.Text))
            {
                MessageBox.Show("Veuillez remplir les champs.",
               "Saisie vide", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            //Empeche la saisie de virgule(,) pour le nom, le prenom, et ou l'id
            
            else
             if (txtPrenomCom.Text.Contains(',') || txtNomCom.Text.Contains(',') || (txtIdCommanditaire.Text.Contains(',')))
            {
                MessageBox.Show("Attention Vous ne pouvez pas utiliser de virgules ( , ) .",
              "Erreur de saisie.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Recuperation des données saisie par l'utilisateur
               
               
                commanditaire.ID = txtIdCommanditaire.Text;
                commanditaire.Prenom = txtPrenomCom.Text;
                commanditaire.NomDeFamille = txtNomCom.Text;

                //lecture des données dans le fichier commanditaire
                gestionaire.LireCommanditaires();

                // on compare le id recupéré au id saisie dans la zone de texte. 
                //un message d'erreur est envoyé si identique, car on veille a ce l'id soit unique
                if(gestionaire.compareIdCommanditaire(commanditaire.ID))
                {
                    MessageBox.Show("Attention ID Commanditaie existe déja, choisir un autre ID .",
                 "Erreur de saisie.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //on ajoute les données dans la structure puis l'enregistre dans le fichier
                //tout en demandant a l'utilisateur de completer la saisie du prix du commanditaire
                
                else
                {
                    gestionaire.AjouterCommanditaire(commanditaire.ID,commanditaire.Prenom, commanditaire.NomDeFamille);
                    gestionaire.EcrireCommanditaire();
                    MessageBox.Show("Veuillez compléter les informations sur le prix !",
                    "Commanditaire sauvegardé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdPrix.Focus();

                }
             
            }

        }

        ////cette methode permet d'initialiser les champs de saisie
        public void effacerChamp()
        {
            txtIdCommanditaire.Text=String.Empty;
            txtPrenomCom.Text = String.Empty;
            txtNomCom.Text = String.Empty;
            txtIdPrix.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtValeur.Text = String.Empty;
            txtQuantitePrix.Text = String.Empty;
        }

        //pour ajouter un prix du commanditaire
        private void btnAjouterPrix_Click(object sender, EventArgs e)

        //Affiche un message d'erreur si la saisie est vide
        {
            Ma_Biblio_De_Classe.Prix prix = new Ma_Biblio_De_Classe.Prix();

           
            if (String.IsNullOrEmpty(txtIdPrix.Text)
                || String.IsNullOrEmpty(txtDescription.Text)
                || String.IsNullOrEmpty(txtValeur.Text)
                || String.IsNullOrEmpty(txtQuantitePrix.Text))
            {
                MessageBox.Show("Veuillez remplir les champs.",
               "Saisie vide", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }

            //Empeche la saisie de virgule(,) pour la description, et  l'id car elle représente le separateur dans le fichier

            else
             if (txtIdPrix.Text.Contains(',') || txtDescription.Text.Contains(',') )
            {
                MessageBox.Show("Attention Vous ne pouvez pas utiliser de virgules ( , ) .",
              "Erreur de saisie.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //l'id du commanditaire doit etre renseigné si ce champ est vide
            else

            if (String.IsNullOrEmpty(txtIdCommanditaire.Text))
            {
                MessageBox.Show("Veuillez renseigner l'ID du Commanditaire.",
             "Saisie vide", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            // on recupere les valeurs saisies dans les champs
            else
            {
               
                prix.IdPrix = txtIdPrix.Text;
                prix.Description = txtDescription.Text;
                prix.Valeur = Double.Parse(txtValeur.Text);
                prix.Qnt_Originale = Int32.Parse(txtQuantitePrix.Text);
                prix.Qnt_Disponible = Int32.Parse(txtQuantitePrix.Text);
                prix.Commanditaire = txtIdCommanditaire.Text;

                commanditaire.ID = txtIdCommanditaire.Text;
              

                //lecture des données dans le fichier commanditaire
                gestionaire.LireCommanditaires();

                //lecture des données dans le fichier prix
                gestionaire.LirePrix();

                // on compare le id recupéré au id saisie dans la zone de texte. 
                //un message d'erreur est envoyé si identique, car on veille a ce l'id du prix
                //soit unique
                if (gestionaire.compareIdPrix(prix.IdPrix))
                {
                    MessageBox.Show("Attention ID Prix existe déja, choisir un autre ID .",
                 "Erreur de saisie.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //on ne doit pas enregistrer un prix sans commanditaire,le commanditaire doit exister au préalable
                //on a ajouté cette partie car 
                //un commanditaire qui existe déja peux vouloir offrir un nouveau prix, il faut alors verifier son id
                //et le saisir dans le champs id commanditaire, si le id saisie n'existe pas dans le fichier
                //un message d'erreur s'affiche.


                else
                 if (!gestionaire.compareIdCommanditaire(commanditaire.ID))
                {
                    MessageBox.Show("Attention ce Commanditaire n'existe pas, choisir un autre ID .",
                 "Erreur de saisie.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdCommanditaire.Focus();
                }

                //si tout se passe bien on enregistre le prix dans le fichier
                else
                {
                    gestionaire.AjouterPrix(prix.IdPrix, prix.Description, prix.Valeur, prix.Qnt_Originale, prix.Qnt_Disponible, prix.Commanditaire);
                    gestionaire.EcrirePrix();
                    MessageBox.Show("Enregistrement Prix reussi.",
                  "Prix.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                }

               
            }
           
        }

        //on lit les données dans le fichier puis on l'affiche dans la listbox
        private void btnAfficherCom_Click(object sender, EventArgs e)
        {
           
            dataGridViewCom.Rows.Clear();
            readCommanditaires();
           
        }


        private void btnAfficherPrix_Click(object sender, EventArgs e)
        {
            dataGridViewPrix.Rows.Clear();
            readPrix();
           
        }

        //pour empecher la saisie de valeur non numerique dans le champs
        private void txtValeur_TextChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in txtValeur.Text)
            {
                if (Char.IsDigit(c))
                    sb.Append(c);
            }
            
            txtValeur.Text = sb.ToString();

    }

        private void txtQuantitePrix_TextChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in txtQuantitePrix.Text)
            {
                if (Char.IsDigit(c))
                    sb.Append(c);
            }

            txtQuantitePrix.Text = sb.ToString();
        }

        //pour vider les champs
        private void btnEffacer_Click(object sender, EventArgs e)
        {
            effacerChamp();


        }

        private void listBoxCom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //cette methode permet de lire le fichier commanditaires et d'afficher les données sur le dataGridView
        private void readCommanditaires()
        {
           
            StreamReader sr = new StreamReader("commanditaires.txt");
             string strLine = string.Empty;
            while ((strLine=sr.ReadLine()) != null)
            {
                string[] strArray = strLine.Split(',');
                dataGridViewCom.Rows.Add(strArray);

            }
            sr.Close();
           
        }

        //cette methode permet de lire le fichier prix et d'afficher les données sur le dataGridView
        private void readPrix()
        {
     
            StreamReader sr = new StreamReader("prix.txt");
            string strLine = string.Empty;
           
            while ((strLine = sr.ReadLine()) != null)
            {
                string[] strArray = strLine.Split(',');
                dataGridViewPrix.Rows.Add(strArray);

            }
            sr.Close();
           
        }



    }
}
