using System;
using System.Collections.Generic;
using System.Text;

namespace Ma_Biblio_De_Classe
{
    //cette classe  permet de creer les prix
    public class Prix
    {
        private string idPrix;
        private string description;
        private double valeur;
        private int qnt_Originale;
        private int qnt_Disponible;
        private string idCommanditaire;

        //les constructeurs
        public Prix(string idPrix, string description, double valeur, int qnt_Originale, int qnt_Disponible, string idCommanditaire)
        {
            this.idPrix = idPrix;
            this.description = description;
            this.valeur = valeur;
            this.qnt_Originale = qnt_Originale;
            this.qnt_Disponible = qnt_Disponible;
            this.idCommanditaire = idCommanditaire;
        }

        public Prix()
        {
        }

        public string IdPrix
        {
            get { return this.idPrix; }
            set { this.idPrix = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public double Valeur
        {
            get { return this.valeur; }
            set { this.valeur = value; }
        }

        public int Qnt_Originale
        {
            get { return this.qnt_Originale; }
            set { this.qnt_Originale = value; }
        }

        public int Qnt_Disponible
        {
            get { return this.qnt_Disponible; }
            set { this.qnt_Disponible = value; }
        }

        public string Commanditaire
        {
            get { return this.idCommanditaire; }
            set { this.idCommanditaire = value; }
        }



        // permet d'afficher differentes proprietes du prix
        public override string ToString()
        {
            return "ID # " + this.idPrix + " ,Description : " + this.description + " ,Valeur : " + this.valeur + " ,Quantite Originale: " + this.qnt_Originale + " ,Quantite Disponible: " + this.qnt_Disponible + " ,Commanditaire: " + this.idCommanditaire.ToString() + "\r\n ";
        }

        public void deduire (int montant)
            {
            }
    }
}
