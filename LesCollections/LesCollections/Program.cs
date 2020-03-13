using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace LesCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            List<Personne> equipe = new List<Personne>();
            List<string> mots = new List<string>();

            Personne p = new Personne("Lagaffe", 25);
            al.Add(p);
            al.Add(new Personne("Jeanne", 20));

            for (int i = 0; i < al.Count; i++) {
                p = (Personne)al[i];
                Console.WriteLine(p.ToString());
                //ou
                Console.WriteLine(al[i].ToString());
            }
            ArrayList joursSemaine = new ArrayList();

            joursSemaine.Add("Lundi");
            joursSemaine.Add("Mercredi");
            joursSemaine.Add("Jeudi");

            Console.WriteLine(joursSemaine[0]);
            Console.WriteLine(joursSemaine[1]);
            Console.WriteLine(joursSemaine[2]);

            Console.WriteLine(joursSemaine[-1]);
            Console.WriteLine(joursSemaine[12]);

            joursSemaine.RemoveAt(1);

            joursSemaine.Insert(1,"Mardi");
            joursSemaine.Insert(2,"Mercredi");

            int index = Convert.ToInt32(Console.ReadLine());
            if(joursSemaine[index]=="Lundi"){
                Console.WriteLine("C'est le premier jour de la semaine");
            }
            else{
                Console.WriteLine("C'est un jour de la semaine");
            }

            for(int i=0;i<joursSemaine.Count;i++){
                Console.WriteLine(joursSemaine[i]);
            }

            foreach(string s in joursSemaine){
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }

    class Personne {
        private string nom;
        private int age;
        public Personne(string n, int a) {
            nom = n;
            age = a;
        }
        public string Nom {
            get {
                return nom;
            }
        }

        public int Age {
            get {
                return age;
            }
        }

        public void HappyBirthday() {
            age = age+1;
        }
    }
}
