using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPLapin
{
    class Lapin
    {
        public Lapin(string surnom, int age)
        {
            this.age = 0;
            surnom = "";
            this.position = 0;
        }

        private string surnom;
        private int age;
        private int position;
        private static Random aleatoire;

        public string Surnom { 
        }

        public int Position { 
        }

        public int Age { 
        }

        public void Avancer()
        {
            this.position = this.position+Lapin.aleatoire.Next(0, 6);
        }
    }
}
