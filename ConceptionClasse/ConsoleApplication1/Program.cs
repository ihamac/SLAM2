using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConceptionClasse
{
    class Bidon
    {
        /*static void Main(string[] args)
        {
            Bidon bidonOrigine;
            Bidon bidonDestination;

            bidonOrigine = new Bidon("gris", 5);
            bidonDestination = new Bidon("vert", 5);

            bidonOrigine.Remplir(5);
            bidonDestination.Remplir(2);
            bidonOrigine.TransvaserDans(bidonDestination, 4);

            Console.WriteLine(bidonOrigine);
            Console.WriteLine(bidonDestination);
        } */
        
        //données membres de l'objet
        private int contenance;
        private int contenanceMax;
        private string couleur;
        //constructeur
        public Bidon(string laCouleur, int laContenanceMax)
        {
            contenance = 0;
            couleur = laCouleur;
            contenanceMax = laContenanceMax;
        }
        //méthodes:fonctions ou procédure
        public void Remplir(int quantite)
        {
            if (contenance + quantite > contenanceMax)
            {
                int surplus = contenance + quantite - contenanceMax;
                Console.WriteLine("Le bidon déborde, vous avez perdu {0} litre(s)", surplus);
                contenance = contenanceMax;
            }
            else if (contenance < 0)
            {
                Console.WriteLine("un bidon de {0} litre(s) contenant {1} litre(s) de couleur {2}", contenanceMax, 0, couleur);
            }

            else
            {
                contenance = contenance + quantite;
            }
        }
        public void vider(int quantite)
        {
            contenance = contenance - quantite;
        }
        //méthode retournant un bidon sous la forme d'une chaine de caractère
        public string ToString()
        {
            return string.Format("un bidon de {0} litre(s) contenant {1} litre(s) de couleur {2}", contenanceMax, contenance, couleur);
        }

    } 
    
    class Program
    {
        static void Main(string[] args)
        {

            Bidon unBidon = new Bidon("Rouge", 5);
            unBidon.Remplir(5);
            unBidon.vider(2);
            Bidon deuxBidon = new Bidon("Orange", 20);
            deuxBidon.Remplir(12);
            deuxBidon.vider(4);
            Bidon troisBidon = new Bidon("Bleu", 10);
            troisBidon.Remplir(3);
            troisBidon.vider(4);
            troisBidon.Remplir(-5);

            Console.WriteLine(unBidon.ToString());
            Console.WriteLine(deuxBidon.ToString());
            Console.WriteLine(troisBidon.ToString());

            Console.ReadLine();
        }
    }
}
