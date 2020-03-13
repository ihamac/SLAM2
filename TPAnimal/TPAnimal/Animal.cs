using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace TPAnimal
{
    class Animal
    {
        private string nom;
        private double poids;
        private int age;
        private string crie;
        private string nourriturePref;
        private string espece;


        public Animal(string nom, string crie, int age, string nourriturePref, double poids, string espece)
        {
            this.nom = nom;
            this.crie = crie;
            this.age = age;
            this.nourriturePref = nourriturePref;
            this.poids = poids;
            this.espece = espece;

        }
        public string Nom
        {
            get
            {
                return this.nom;
            }
        }
        public string Crie
        {
            get
            {
                return this.crie;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
        }
        public string NourrtiturePref
        {
            get
            {
                return this.nourriturePref;
            }
        }
        public double Poids
        {
            get
            {
                return this.poids;
            }
        }
        public string Espece
        {
            get
            {
                return this.espece;
            }
        }

        public void Crier()
        {
            Console.WriteLine("Mon crie est : {0}", this.crie);
        }
        public double Boire(double Quantité)
        {
            return Quantité;
        }
        public void SeNourir(int Type)
        {

        }
        public string ToString()
        {
            return string.Format("L'animal s'appel {0}, il a {1}ans, sa nourriture preférée est {2}, son crie est {3}, il pèse {4}kg et son espèce est {5}.", this.nom, this.age, this.nourriturePref, this.crie, this.poids, this.espece);
        }

        public void AfficherFor(List<Animal> Animaux)
        {
            for (int i = 0; i < Animaux.Count; i++)
            {
                Console.WriteLine(Animaux[i].ToString());
            }
        }

        public void AfficherForeach(List<Animal> Animaux)
        {
            foreach (Animal nom in Animaux)
            {
                Console.WriteLine(nom.ToString());
            }
        }

        public void NbEelements(List<Animal> Animaux)
        {
            if (Animaux.Count > 0)
            {
                Console.WriteLine("Il y'a {0} éléments dans la liste.",Animaux.Count);
            }
            else
            {
                Console.WriteLine("La collection est vide");
            }
        }

        public void Ajouter(List<Animal> l, Animal a) {
            Console.WriteLine("Saisissez un nouvel animal en précisant son nom, son crie, son âge, sa nourriture preférée, son poids et son espèce : ");
            string nom = Convert.ToString(Console.ReadLine());
            string crie = Convert.ToString(Console.ReadLine());
        }
        public void Afficher(List<Animal> l){
        
        }
        public void Vider(List<Animal> l){
        
        }
        public void Supprimer(List<Animal> l, int position) { 
        
        }
        public int Trouver(List<Animal> l, string nom){
        
        }
        public void Insérer(List<Animal> l, Animal a, int position)
        {

        }
    }
}
