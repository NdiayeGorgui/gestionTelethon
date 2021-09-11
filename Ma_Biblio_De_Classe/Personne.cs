using System;

namespace Ma_Biblio_De_Classe
{
    //une classe de base qui seras herité par donateur et commanditaire
    public class Personne
    {
        private string prenom;
        private string nomDeFamille;

        //les getters et setters
        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }

        public string NomDeFamille
        {
            get { return this.nomDeFamille; }
            set { this.nomDeFamille = value; }
        }

        // redefinition de ToString() /permet d'afficher differentes proprietes de la personne
        public override string ToString()
        {
            string nom = this.prenom + " " + this.nomDeFamille;
            return nom;
        }
    }
}
