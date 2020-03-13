using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProcédureFonction
{
    class Program
    {
        //HAMAC Inès
        static void Main(string[] args)
        {
            int nombrePersonne = Convert.ToInt32(Console.ReadLine());
            int[] lesQI = new int[nombrePersonne];
            SaisirQi(lesQI);
            int lePlusStupide = PlusStupide(lesQI);
            Console.WriteLine(QiGroupe(lesQI  /*Attention les paramètres de la fonction sont à déduire*/));
        }

        //1) Ecrire la procèdure SaisirQi qui permet de saisir dans un tableau les Qi d'un groupe.
        static void SaisirQi(int[] Qi)
        {
            for (int i = 0; i < Qi.Length; i++) //Boucle de saisie adapté à toute longueur de tableau
            {
                Console.WriteLine("Saisissez le Qi de la personne {0} :", i + 1);
                Qi[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        //2) Ecrire la fonction PlusStupide qui donne le qi de la personne la plus stupide d'un groupe.
        static int PlusStupide(int[] Qi)
        {
            int lePlusStupide = Qi[0];
            for (int i = 1; i < Qi.Length; i++) //On parcourt le tableau
            {
                if (Qi[1] < lePlusStupide) //Si la condition est vraie alors ça l'ajoute au tableau
                {
                    lePlusStupide = Qi[i];
                }
            }
            return lePlusStupide;
        }

        //3) Ecrire la fonction QiGroupe qui calcule le Qi d'un groupe
        static int QiGroupe(int[] Qi)
        {
            int j = 0;
            for (int i = 0; i < Qi.Length; i++) //On parcourt le tableau en effectuant le calcul
            {
                j = Qi[i] + i;

            }
            return j / Qi.Length;

        }
    }
}
