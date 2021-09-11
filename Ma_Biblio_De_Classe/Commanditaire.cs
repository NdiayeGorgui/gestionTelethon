using System;
using System.Collections.Generic;
using System.Text;

namespace Ma_Biblio_De_Classe
{
    //cette classe herite de la classe personne et permet de creer les commanditaires
    
    public class Commanditaire:Personne
    {
       
        private string idCommanditaire;

        //les Constructeurs
        public Commanditaire()
        {
        }

        public Commanditaire(string id, string prenom, string nomFamille )
        {
            this.Prenom = prenom;
            this.NomDeFamille = nomFamille;
            this.idCommanditaire = id;
        }

        //les getters et setters
        public string ID
        {
            get { return this.idCommanditaire; }
            set { this.idCommanditaire = value; }
        }

        //redefinition de la methode ToString()
        public override string ToString()
        {
            // permet d'afficher differentes proprietes du commanditaire
         return "ID #: " + this.idCommanditaire + ", PRÉNOM: " + this.Prenom + ", NOM: " + this.NomDeFamille.ToString() + "\r\n ";
        }
    }
}
