using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstObject
{
    class Client
    {
        private string nom;
        private string prenom;
        private string numeroTelephone;
        public List<CompteBancaire> compteBancaire;

        public Client(string nom, string prenom, string numeroTelephone)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.numeroTelephone = numeroTelephone;
            compteBancaire = null;
        }
        public Client(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.numeroTelephone = "";
            compteBancaire = null;
        }
        public string DecrireClient()
        {
            string description =  nom + " " + prenom + " et son num de tel est : " + numeroTelephone;
            return description;
        }
    }
}
