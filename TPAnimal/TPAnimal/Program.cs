using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TPAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Chien = new Animal("Guizmo", "Wouf", 3, "du poulet", 40, "Canidé");
            Animal Chat = new Animal("Chilla", "Miaou", 10, "du poisson", 16, "Félin");
            Animal Loup = new Animal("Jok'air", "Ahouu", 12, "de la viande", 28, "Canidé");
            Animal Tortue = new Animal("Colombine", "Brouik", 100, "de la mâche", 160, "Reptile");
            Animal PoissonRouge = new Animal("Nepal", "Gluglu", 2, "de la coke", 0.3, "Vertebré Aquatique");

            List<Animal> Animaux = new List<Animal>();
            Animaux.Add(Chien);
            Animaux.Add(Chat);
            Animaux.Add(Loup);
            Animaux.Add(Tortue);
            Animaux.Add(PoissonRouge);

            //Chien.AfficherFor(Animaux);
            Chien.NbEelements(Animaux);


            Console.WriteLine("Votre choix : ");
            int Menu = Convert.ToInt32(Console.ReadLine());

            switch (Menu)
            {
                case 1:
                    Console.WriteLine("1. Ajouter");
                    break;
                case 2:
                    Console.WriteLine("2. Liste");
                    break;
                case 3:
                    Console.WriteLine("3. Vider");
                    break;
                case 4:
                    Console.WriteLine("4. Trouver");
                    break;
                case 5:
                    Console.WriteLine("5. Supprimer");
                    break;
                case 6:
                    Console.WriteLine("6. Insérer");
                    break;

            }

            Console.ReadLine();
        }
    }
}
