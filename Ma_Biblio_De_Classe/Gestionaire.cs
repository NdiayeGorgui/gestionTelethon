using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Ma_Biblio_De_Classe
{
   // c'est dans cette classe que nous avons creer toute les methodes de gestion de l'application
    public class Gestionaire
    {

        List<Donateur> donateurs = new List<Donateur>();
        List<Commanditaire> commanditaires = new List<Commanditaire>();
        List<Don> dons = new List<Don>();
        List<Prix> prix = new List<Prix>();

   

        public const string calendrier = "Prix attribué, un Calendrier";
        public const string televiseur = "Prix attribué, un Téléviseur";
        public const string bbq = "Prix attribué, un BBQ";
        public const string repas = "Prix attribué, un Repas pour 2";
        public const string desole = "Désolé vous n'avez rien gagné !";


        //pour ajouter un donateur
        public void AjouterDonateur(string id,string prenom, string nomFamille, string adresse, string telephone,string typeDeCarte,string numeroDeCarte, string dateExpiration)
        {
          
            Donateur donateur = new Donateur(id,prenom, nomFamille, adresse,telephone,typeDeCarte,numeroDeCarte,dateExpiration);
            donateurs.Add(donateur);
        }

        //pour ajouter un commanditaire
        public void AjouterCommanditaire(string id,string prenom, string nomFamille )
        {
          
            Commanditaire commanditaire = new Commanditaire(id,prenom, nomFamille );
            commanditaires.Add(commanditaire);
        }

        /*pour ajouter un prix offert par un commanditaire,
        lors de l'enregistrement on recupere l'id du commanditaire
        vérifier si commanditaire existe avant d'ajouter le prix,
        cela permet d'eviter d'avoir des prix sans commanditaire*/
        public void AjouterPrix(string idPrix, string description, double valeur, int qnt_Originale, int qnt_Disponible, string commanditaire)
        {
            
            getCommanditaire(commanditaire).ID.Equals(commanditaire);
           
            Prix leprix = new Prix(idPrix, description, valeur, qnt_Originale, qnt_Disponible, commanditaire);
            
            prix.Add(leprix);
        }

        /*pour ajouter un don offert par un donateur,
       lors de l'enregistrement on recupere l'id du donateur
       vérifier si donateur existe avant d'ajouter le don,
       cela permet d'eviter d'avoir des don sans donateur*/
        public void AjouterDon(string id, double montantDuDon, string dateDuDon, string donateur)
        {
            //vérifier si donnateur existe existe
            getDonateur(donateur).ID.Equals(donateur);
       
            Don don = new Don(id, montantDuDon, dateDuDon,donateur );
            dons.Add(don);
        }

        //parcourrir la liste des donateurs pour les  afficher
        public string AfficherDonateur()
        {
            string listeDonateurs = String.Empty;
            foreach (Donateur donateur in donateurs)
            {
                listeDonateurs += donateur.ToString();
            }
            return listeDonateurs;
        }

        //parcourrir la liste des commanditaires pour les  afficher
        public string AfficherCommanditaire()
        {
            string listeCommanditaires = String.Empty;
            foreach (Commanditaire commanditaire in commanditaires)
            {
               
                listeCommanditaires +=  commanditaire.ToString();
               
            }
            return listeCommanditaires;
        }
        //parcourrir la liste des prix pour les  afficher
        public string AfficherLePrix()
        {
            string listePrix = String.Empty;
            foreach (Prix leprix in prix)
            {
                listePrix +=  leprix.ToString();
            }
            return listePrix;
        }

        // pour afficher le prix gagné par le donateur selon le montant donné
        public string AfficherPrix(int nombrePoint,double montant)
        {
           // double montant = 0;
            if (AttribuerPrix(montant) >= 1 && AttribuerPrix(montant)<9)
            {
               
                return calendrier;
            }
            else
                if (AttribuerPrix(montant) >= 10 && AttribuerPrix(montant) < 15)
            {
                return repas;
            }
            if (AttribuerPrix(montant) >= 15 && AttribuerPrix(montant) < 20)
            {
                return bbq;
            }
            if (AttribuerPrix(montant) >= 20)
            {
                return televiseur;
            }
            else
                return desole;
            
            
        }

        //parcourrir la liste des dons pour les  afficher
        public string AfficherDon()
        {
            string listeDons = String.Empty;
            foreach (Don don in dons)
            {
                listeDons += don.ToString();
            }
            return listeDons;
        }

        // pour attribuer un prix a un donateur selon les conditions fixées
        public int AttribuerPrix(double montant)
        {
           

            if (montant >= 50 && montant <= 199)
            {
                return 1;
            }
               
            else
            if (montant >= 200 && montant <= 349)
            {
                return 2;
            }
               
            else
            if (montant >= 350 && montant <= 499)
            {
                return 3;
            }
                
            else 
            if (montant >= 500 && montant<1000)
            {
                return 5;
            }
            else
            if (montant >= 1000 && montant <1500)
            {
                return 10;
            }
            else
            if (montant >= 1500 && montant < 2000)
            {
                return 15;
            }
            else
            if (montant >= 2000 )
            {
                return 20;
            }
            return 0;
              
        }

        //pour verifier l'existance d'un donateur dans la liste et le recuperer 
        public Donateur getDonateur(string id)
        {
            for (int i = 0; i < donateurs.Count; i++)
                if (id == donateurs[i].ID)
                    return donateurs[i];
            throw new Exception("ID du donateur inexistant.");

        }

        //pour verifier l'existance d'un comanditaire dans la liste et le recuperer 
        public Commanditaire getCommanditaire(string id)
        {
            for (int i = 0; i < commanditaires.Count; i++)
                if (id == commanditaires[i].ID)
                    return commanditaires[i];
            throw new Exception("ID du commanditaire inexistant.");

        }
        //pour comaparer l'id du commanditaire saisie dans la zone de texte et les id deja existant
        //en effet nous voulons eviter les doublon des id dans le fichier
        public bool compareIdCommanditaire(string id)
        {
            for (int i = 0; i < commanditaires.Count; i++) { 
                if (id == commanditaires[i].ID)
                    return true;
            }
            return false;
        }


        //pour comaparer l'id du prix saisie dans la zone de texte et les id deja existant
        //en effet nous voulons eviter les doublon des id dans le fichier
        public bool compareIdPrix(string id)
        {
            for (int i = 0; i < prix.Count; i++)
            {
                if (id == prix[i].IdPrix)
                    return true;
            }
            return false;
        }

        //pour comaparer l'id du donateur saisie dans la zone de texte et les id deja existant
        //en effet nous voulons eviter les doublon des id dans le fichier
        public bool compareIdDonateur(string id)
        {
            for (int i = 0; i < donateurs.Count; i++)
            {
                if (id == donateurs[i].ID)
                    return true;
            }
            return false;
        }

        //pour comaparer l'id du don saisie dans la zone de texte et les id deja existant
        //en effet nous voulons eviter les doublon des id dans le fichier
        public bool compareIdDon(string id)
        {
            for (int i = 0; i < dons.Count; i++)
            {
                if (id == dons[i].IdDon)
                    return true;
            }
            return false;
        }

       
       

        // pour ecrire les commanditaires dans un fichier texte
       
        public void EcrireCommanditaire()
        {
             
        StreamWriter sw = new StreamWriter("commanditaires.txt", false);
            for (int i = 0; i < commanditaires.Count; i++)
            {

                if (i == commanditaires.Count - 1)
                {
                    sw.Write("{0},{1},{2}", commanditaires[i].ID, commanditaires[i].Prenom, commanditaires[i].NomDeFamille );
                }
                else
                {
                    sw.WriteLine("{0},{1},{2}", commanditaires[i].ID, commanditaires[i].Prenom, commanditaires[i].NomDeFamille);
                }

            }
            sw.Close();
         
        }

        // pour ecrire les donateurs dans un fichier texte
        public void EcrireDonateur()
        {
            StreamWriter sw = new StreamWriter("donateurs.txt", false);
            for (int i = 0; i < donateurs.Count; i++)
            {
                if (i == donateurs.Count - 1)
                { 
                    sw.Write("{0},{1},{2},{3},{4},{5},{6},{7}", donateurs[i].ID, donateurs[i].Prenom, donateurs[i].NomDeFamille, donateurs[i].Adresse, donateurs[i].Telephone, donateurs[i].TypeDeCarte, donateurs[i].NumeroDeCarte, donateurs[i].DateExpiration);
                }
                else
                {
                    sw.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", donateurs[i].ID, donateurs[i].Prenom, donateurs[i].NomDeFamille, donateurs[i].Adresse, donateurs[i].Telephone, donateurs[i].TypeDeCarte, donateurs[i].NumeroDeCarte, donateurs[i].DateExpiration);
                }
            }
            sw.Close();
           
           
        }

        // pour ecrire les dons dans un fichier texte
        public void EcrireDon()
        {
            StreamWriter sw = new StreamWriter("dons.txt", false);
            for (int i = 0; i < dons.Count; i++)
            {

                if (i == dons.Count - 1)
                
                    sw.Write("{0},{1},{2},{3}", dons[i].IdDon, dons[i].MontantDuDon, dons[i].DateDuDon, dons[i].Donateur);
                
                else
                
                    sw.WriteLine("{0},{1},{2},{3}", dons[i].IdDon ,dons[i].MontantDuDon, dons[i].DateDuDon, dons[i].Donateur );
                

            }
            sw.Close();
           
        }

        // pour ecrire les prix dans un fichier texte
        public void EcrirePrix()
        {
            StreamWriter sw = new StreamWriter("prix.txt", false);
            for (int i = 0; i < prix.Count; i++)
            {

                if (i == prix.Count - 1)
                {
                    sw.Write("{0},{1},{2},{3},{4},{5}", prix[i].IdPrix, prix[i].Description, prix[i].Valeur, prix[i].Qnt_Originale, prix[i].Qnt_Disponible, prix[i].Commanditaire);
                }
                else
                {
                    sw.WriteLine("{0},{1},{2},{3},{4},{5}", prix[i].IdPrix, prix[i].Description, prix[i].Valeur, prix[i].Qnt_Originale, prix[i].Qnt_Disponible, prix[i].Commanditaire);
                }

            }
            sw.Close();
           
        }

        // pour lire les commanditaires dans le fichier texte
        public bool LireCommanditaires()
        {
           // string[] strArray;
            StreamReader sr = new StreamReader("commanditaires.txt");
           // string strLine = string.Empty;
           string  strLine = sr.ReadLine();
            commanditaires.Clear();
            while (strLine != null)
            {
                string[] strArray = strLine.Split(',');
                commanditaires.Add(new Commanditaire(strArray[0], strArray[1], strArray[2]));
                strLine = sr.ReadLine();
               
            }
            sr.Close();
            return true;
        }

        // pour ecrire les donateurs dans le fichier texte
        public bool LireDonateurs()
        {
            string[] strArray;
            StreamReader sr = new StreamReader("donateurs.txt");
            string strLine = sr.ReadLine();
            donateurs.Clear();
            while (strLine != null)
            {
                strArray = strLine.Split(',');
                donateurs.Add(new Donateur(strArray[0], strArray[1], strArray[2], strArray[3], strArray[4], strArray[5], strArray[6], strArray[7]));
                strLine = sr.ReadLine();
            }
            sr.Close();
            return true;
        }

        // pour ecrire les dons dans le fichier texte
        public bool LireDons()
        {
            string[] strArray;
            StreamReader sr = new StreamReader("dons.txt");
            string strLine = sr.ReadLine();
            dons.Clear();
            while (strLine != null)
            {
                strArray = strLine.Split(',');
                dons.Add(new Don(strArray[0], Double.Parse(strArray[1]), strArray[2], strArray[3] ));
                strLine = sr.ReadLine();
               
            }
            sr.Close();
            return true;
        }

        // pour ecrire les prix dans le fichier texte
        public bool LirePrix()
        {
            string[] strArray;
            StreamReader sr = new StreamReader("prix.txt");
            string strLine = sr.ReadLine();
            prix.Clear();
            while (strLine != null)
            {
                strArray = strLine.Split(',');
                prix.Add(new Prix(strArray[0], strArray[1], Double.Parse(strArray[2]), Int32.Parse(strArray[3]), Int32.Parse(strArray[4]), strArray[5]));
                strLine = sr.ReadLine();
            }
            sr.Close();
            return true;
        }


    }
}
