using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPBanque
{
    class Program
    {
        static void Main(string[] args)
        {
            Banque b1 = new Banque("Crédit lyonnais");
            Banque b2 = new Banque("Société Générale");

            Compte c1 = new Compte(1, "Harry Tuttle", 0, -200);
            Compte c2 = new Compte(2, "Jill Layton", 100, -100);

            b1.AjouteCompte(c1);
            b2.AjouteCompte(c2);
            b1.AjouteCompte(3, "Sam Lowry", 1000, -500);
            b1.AjouteCompte(4, "Jack Lint", 200, 0);

            for (int i = 0; i < b1.Count; i++) {
                Console.WriteLine(b1.GetCompte(i).ToString());
            }

            Console.ReadLine();
        }
    }
}
