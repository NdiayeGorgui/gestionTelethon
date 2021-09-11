using System;
using System.Collections.Generic;
using System.Text;

namespace Ma_Biblio_De_Classe
{
    //cette classe herite de la classe personne et permet de creer les donnateurs
    public class Donateur:Personne
    {
        private string idDonateur;
        private string adresse;
        private string telephone;
        private string typeDeCarte;
        private string numeroDeCarte;
        private string dateExpiration;

        //les constructeurs
        public Donateur()
        {
        }

        public Donateur(string id,string prenom, string nomFamille , string adresse,string telephone , string typeDeCarte, string numeroDeCarte, string dateExpiration)
        {
            this.Prenom = prenom;
            this.NomDeFamille = nomFamille;
            this.idDonateur = id;
            this.telephone = telephone;
            this.adresse = adresse;
            this.typeDeCarte = typeDeCarte;
            this.numeroDeCarte = numeroDeCarte;
            this.dateExpiration = dateExpiration;
        }

        //les getters et setters
        public string ID
        {
            get { return this.idDonateur; }
            set { this.idDonateur = value; }
        }

        public string Adresse
        {
            get { return this.adresse; }
            set { this.adresse = value; }
        }

        public string Telephone
        {
            get { return this.telephone; }
            set { this.telephone = value; }
        }

        public string TypeDeCarte
        {
            get { return this.typeDeCarte; }
            set { this.typeDeCarte = value; }
        }

        public string NumeroDeCarte
        {
            get { return this.numeroDeCarte; }
            set { this.numeroDeCarte = value; }
        }

        public string DateExpiration
        {
            get { return this.dateExpiration; }
            set { this.dateExpiration = value; }
        }

        //redefinition de la methode ToString()
        public override string ToString()
        {
            // permet d'afficher differentes proprietes du donateur

            return "ID : " + this.idDonateur + ",Prénom : " + this.Prenom + " Nom : " + this.NomDeFamille + " ,Email  : " + this.adresse + " ,Telephone  : " + this.telephone +  " ,Type carte : " + this.typeDeCarte + " ,Numero carte : " + this.numeroDeCarte + " ,Date Expiration : " + this.dateExpiration.ToString() + "\r\n ";
        }


    }      
    }

