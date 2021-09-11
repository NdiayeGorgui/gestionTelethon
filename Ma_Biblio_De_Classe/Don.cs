using System;
using System.Collections.Generic;
using System.Text;

namespace Ma_Biblio_De_Classe
{
    //cette classe  permet de gerer  les dons des differents donateurs
    public class Don
    {
        private string idDon;
        private string dateDuDon;
        private string idDonateur;
        private double montantDuDon;

        //les constructeurs
        public Don()
        {
        }

        public Don(string idDon, double montantDuDon, string dateDuDon, string idDonateur )
        {
            this.idDon = idDon;
            this.dateDuDon = dateDuDon;
            this.idDonateur = idDonateur;
            this.montantDuDon = montantDuDon;
        }


        //les getters et setteurs
        public string IdDon
        {
            get { return this.idDon; }
            set { this.idDon = value; }
        }

        public string DateDuDon
        {
            get { return this.dateDuDon; }
            set { this.dateDuDon = value; }
        }

        public string Donateur
        {
            get { return this.idDonateur; }
            set { this.idDonateur = value; }
        }

        public double MontantDuDon
        {
            get { return this.montantDuDon; }
            set { this.montantDuDon = value; }
        }

        // redefinition  de lamethode ToString()
        public override string ToString()
        // permet d'afficher differentes proprietes du don

        {
            return "ID # " + this.idDon + " ,Montant don : " + this.montantDuDon+ " ,Date: " + this.dateDuDon + " ,Donateur: " + this.idDonateur.ToString() + "$\r\n ";
        }
    }
}
