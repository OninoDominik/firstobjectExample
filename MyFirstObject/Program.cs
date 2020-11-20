using System;

namespace MyFirstObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Client dom = new Client("Grobecker", "Dominik", "0642251749");
            CompteBancaire compteDom = new CompteBancaire(dom, "euro", 200);
            compteDom.DecrireLeCompte();
        }
    }
}
