using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Ma_Biblio_De_Classe;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Mon_Projet_Telethon
{
    public partial class Donateur : Form
    {
        Gestionaire gestionaire = new Gestionaire();
        Ma_Biblio_De_Classe.Donateur monDonateur = new Ma_Biblio_De_Classe.Donateur();
        public Donateur()
        {
            InitializeComponent();
        }

        private void btnQuiterDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjoutDon_Click(object sender, EventArgs e)
        {
            Ma_Biblio_De_Classe.Don don = new Ma_Biblio_De_Classe.Don();

           
        }

        //pour ajouter un donateur
        private void btnAjouterDonateur_Click(object sender, EventArgs e)
        {

            //Affiche un message d'erreur si la saisie est vide

            if (String.IsNullOrEmpty(txtIdDonateur.Text)
               || String.IsNullOrEmpty(txtPrenom.Text)
               || String.IsNullOrEmpty(txtNom.Text)
               || String.IsNullOrEmpty(txtTelephone.Text)
               || String.IsNullOrEmpty(txtNumeroCarte.Text)
               || String.IsNullOrEmpty(dtpExpiration.Text))
              // || String.IsNullOrEmpty(monDonateur.TypeDeCarte))

            {
                MessageBox.Show("Veuillez remplir les champs.",
                "Saisie vide", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            //Empeche la saisie de virgule(,) pour le nom, le prenom, et ou l'id car elle représente le separateur dans le fichier
            else
             if (txtPrenom.Text.Contains(',') || txtNom.Text.Contains(',') || (txtIdDonateur.Text.Contains(',')))
            {
                MessageBox.Show("Attention Vous ne pouvez pas utiliser de virgules ( , ) .",
              "Erreur de saisie.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                //Recuperation des données saisie par l'utilisateur

                monDonateur.ID = txtIdDonateur.Text;
                monDonateur.Prenom = txtPrenom.Text;
                monDonateur.NomDeFamille = txtNom.Text;

                monDonateur.Adresse = txtEmail.Text;

                //regex pour verifier l'adresse email format:gogo@rosemont.com

                Regex myRegexMail = new Regex(@"^([\w]+)@([\w]+)((\.([\w]+)))+$");

                bool x = myRegexMail.IsMatch(monDonateur.Adresse);

                monDonateur.Telephone = txtTelephone.Text;

                //regex pour numéro de telephone format: 514-641-2641 ou (514)-641-2641

                Regex myRegexPhone = new Regex(@"^?\(?\d{3}?\)??-??\(?\d{3}?\)??-??\(?\d{4}?\)??-?$");

                bool y = myRegexPhone.IsMatch(monDonateur.Telephone);
               
                monDonateur.NumeroDeCarte = txtNumeroCarte.Text;
                monDonateur.DateExpiration = dtpExpiration.Text;

                if (rdbVisa.Checked)
                {
                    monDonateur.TypeDeCarte = rdbVisa.Text;
                }
                else if (rdbMasterCard.Checked)
                {
                    monDonateur.TypeDeCarte = rdbMasterCard.Text;
                }
                else if (rdbAmex.Checked)
                {
                    monDonateur.TypeDeCarte = rdbAmex.Text;
                }

                //lecture des données dans le fichier donateur
                gestionaire.LireDonateurs();


                // on compare le id recupéré au id saisie dans la zone de texte. 
                //un message d'erreur est envoyé si identique, car on veille a ce l'id soit unique
                if (gestionaire.compareIdDonateur(monDonateur.ID))
                {
                    MessageBox.Show("Attention ID Donateur existe déja, choisir un autre ID .",
                 "Erreur de saisie.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 

                //validation de l'adresse Email, le mail peut etre vide si c'est le cas on respecte le format
                else
                 if (!(x || String.IsNullOrEmpty(monDonateur.Adresse)))
                {
                    MessageBox.Show("Format: gogo@rosemont.com",
                                   "Adresse Email invalide.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //validation telephone
                else
                 if (!y)
                {
                    MessageBox.Show("Format: 514-641-2641 ou (514)-641-2641",
                                   "Numéro téléphone invalide.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //on ajoute les données dans la structure puis l'enregistre dans le fichier
                //tout en demandant a l'utilisateur de completer la saisie du don du donateur
                else
                {
                    gestionaire.AjouterDonateur(monDonateur.ID,monDonateur.Prenom, monDonateur.NomDeFamille , monDonateur.Adresse, monDonateur.Telephone, monDonateur.TypeDeCarte, monDonateur.NumeroDeCarte, monDonateur.DateExpiration);
                    gestionaire.EcrireDonateur();

                    MessageBox.Show("Veuillez compléter les informations sur le Don !",
                   "Donateur sauvegardé", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtIdDon.Focus();
                }

               
            }
        }

        //pour ajouter un don du donateur
        private void bntAjoutdon_Click(object sender, EventArgs e)
        {
            //Affiche un message d'erreur si la saisie est vide
            if (String.IsNullOrEmpty(txtIdDon.Text) || String.IsNullOrEmpty(txtMontant.Text))
            {
                MessageBox.Show("Veuillez remplir les champs.",
             "Saisie vide", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            //Empeche la saisie de virgule(,) pour  l'id car elle reprsente le separateur dans notre fichier
            else
             if (txtIdDon.Text.Contains(',') )
            {
                MessageBox.Show("Attention Vous ne pouvez pas utiliser de virgules ( , ) .",
              "Erreur de saisie.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //l'id du donateur doit etre renseigné si ce champ est vide
            else

            if (String.IsNullOrEmpty(txtIdDonateur.Text))
            {
                MessageBox.Show("Veuillez renseigner l'ID du Donateur.",
             "Saisie vide", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            // on recupere les valeurs saisies dans les champs
            else
            {

                Ma_Biblio_De_Classe.Don monDon = new Ma_Biblio_De_Classe.Don();
                monDon.IdDon = txtIdDon.Text;
                monDon.MontantDuDon = Double.Parse(txtMontant.Text);
                monDon.Donateur = txtIdDonateur.Text;
                monDon.DateDuDon = DateTime.Now.ToString();

                monDonateur.ID = txtIdDonateur.Text;

                //lecture des données dans le fichier donateur
                gestionaire.LireDonateurs();

                //lecture des données dans le fichier don
                gestionaire.LireDons();

                // on compare le id recupéré au id saisie dans la zone de texte. 
                //un message d'erreur est envoyé si identique, car on veille a ce l'id du don
                //soit unique

                if (gestionaire.compareIdDon(monDon.IdDon))
                {
                    MessageBox.Show("Attention ID Don existe déja, choisir un autre ID .",
                 "Erreur de saisie.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //on ne doit pas enregistrer un don sans donateur,le donateur doit exister au préalable
                //on a ajouté cette partie car 
                //un donateur qui existe déja peux vouloir offrir un nouveau don, il faut alors verifier son id
                //et le saisir dans le champs id commanditaire, si le id saisie n'existe pas dans le fichier
                //un message d'erreur s'affiche.
               

                else
                 if (!gestionaire.compareIdDonateur(monDonateur.ID))
                {
                    MessageBox.Show("Attention ce Donateur n'existe pas, choisir un autre ID .",
                 "Erreur de saisie.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdDonateur.Focus();
                }

                //si tout se passe bien on enregistre dans le don dans fichier
                else
                {
                    double montant = gestionaire.AttribuerPrix(monDon.MontantDuDon);
                    txtNbPoint.Text = montant.ToString();
                    gestionaire.AjouterDon(monDon.IdDon, monDon.MontantDuDon, monDon.DateDuDon, monDon.Donateur);
                    gestionaire.EcrireDon();
                    MessageBox.Show("Enregistrement Don reussi.",
                   "Don.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                }
               


            }
        }

        //on lit les données dans le fichier puis on l'affiche dans le dataGridViewDonateur
        private void btnAfficherDonateur_Click(object sender, EventArgs e)
        {
            dataGridViewDonateur.Rows.Clear();
            readDonateurs();
        }

        //on lit les données dans le fichier puis on l'affiche dans le dataGridViewDon
        private void btnAfficherDon_Click(object sender, EventArgs e)
        {
            dataGridViewDon.Rows.Clear();
            readDons();
        }

        private void btnAffichePrix_Click(object sender, EventArgs e)
        {
           //empecher la saisie vide

            if (String.IsNullOrEmpty(txtNbPoint.Text))
            {
                MessageBox.Show("Attention nombre de point manquant, Ajouter Don.",
             "Saisie vide", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdDon.Focus();
            }
            else

            {
              //afficher le prix dans la zone réservé
                string prix = gestionaire.AfficherPrix(Int32.Parse(txtNbPoint.Text), Double.Parse(txtMontant.Text));
                txtPrixAttribue.Text=prix;

            }
        }

        //pour fermer la page
        private void btnQuiterDonateur_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //vider les champs
        private void btnEffacer_Click(object sender, EventArgs e)
        {
            effacerChamp();
        }

        //pour empecher la saisie de valeur non numerique dans le champs
        private void txtMontant_TextChanged(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();

            foreach (char c in txtMontant.Text)
            {
                if (Char.IsDigit(c))
                    sb.Append(c);
            }

            txtMontant.Text = sb.ToString();

        }

        //cette methode permet d'initialiser les champs de saisie
        public void effacerChamp()
        {
            txtIdDonateur.Text = String.Empty;
            txtPrenom.Text = String.Empty;
            txtNom.Text = String.Empty;
            txtNumeroCarte.Text = String.Empty;
            txtTelephone.Text = String.Empty;
            txtIdDon.Text = String.Empty;
            txtMontant.Text = String.Empty;
            txtEmail.Text = String.Empty;
           

        }
      
        private void Donateur_Load(object sender, EventArgs e)
        {
          
        }
        //cette methode permet de lire le fichier donnateurs et d'afficher les données sur le dataGridView
        private void readDonateurs()
        {
            
            StreamReader sr = new StreamReader("donateurs.txt");
            string strLine = string.Empty;
            while ((strLine = sr.ReadLine()) != null)
            {
                string[] strArray = strLine.Split(',');
                dataGridViewDonateur.Rows.Add(strArray);
               
            }
            sr.Close();
           
        }

        //cette methode permet de lire le fichier dons et d'afficher les données sur le dataGridView
        private void readDons()
        {
            
            StreamReader sr = new StreamReader("dons.txt");
            string strLine = string.Empty;
            while ((strLine = sr.ReadLine()) != null)
            {
                string[] strArray = strLine.Split(',');
                dataGridViewDon.Rows.Add(strArray);
              
            }
            sr.Close();
           
        }
    }
}
