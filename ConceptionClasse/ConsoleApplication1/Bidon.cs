using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConceptionClasse
{
    class Bidon
    {
        static void Main(string[] args)
        {
            Bidon unBidon = new Bidon("rouge", 5);
            unBidon.Remplir(5);
            unBidon.vider(2);
            Bidon deuxBidon = new Bidon("orange", 20);
            unBidon.Remplir(12);
            deuxBidon.vider(4);
            Bidon troisBidon = new Bidon("Bleu", 10);
            unBidon.Remplir(3);
            unBidon.vider(4);
            unBidon.Remplir(-5);

            Console.WriteLine(unBidon.ToString());
            Console.WriteLine(deuxBidon.ToString());
            Console.WriteLine(troisBidon.ToString());
        }

        //données membres de l'objet
        private int contenance;
        private int contenanceMax;
        private string couleur;

        //constructeur
        public Bidon(string laCouleur, int laContenanceMax) {
            contenance = 0;
            couleur = laCouleur;
            contenanceMax = laContenanceMax;

        }
        //méthodes:fonctions ou procédure
        public void Remplir(int quantite) {
            if (contenance + quantite > contenanceMax)
            {
                int surplus = contenance + quantite - contenanceMax;
                Console.WriteLine("ça déborde de {0} litre(s)", surplus);
                contenance = contenanceMax;
            }
            else {
                contenance = contenance + quantite;
            }

        }
        public void vider(int quantite) {
            contenance = contenance - quantite;
        }
        //méthode retournant un bidon sous la forme d'une chaine de caractère
        public string ToString() {
            return string.Format("un bidon {0} litre(s) contenant {1} libtre(s) de couleur {2}", contenanceMax, contenance, couleur);
        }
    } 
}

