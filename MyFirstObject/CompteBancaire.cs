using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstObject
{
    class CompteBancaire
    {
        public Client client;
        private string devise;
        private int solde;

        public CompteBancaire(Client client, string devise, int solde)
        {
            this.client = client;
            this.devise = devise;
            this.solde = solde;
        }
        public void DecrireLeCompte()
        {
            Console.WriteLine(client.DecrireClient() + " a un solde de " + solde + " " + devise);
        }


    }
}
