using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPLapin
{
    class Program
    {
        static void Main(string[] args)
        {
            Lapin L1;
            Lapin L2;
            Lapin L3;

            L1 = new Lapin("Rayhane", 19);
            L2 = new Lapin("Matthias", 18);
            L3 = new Lapin("David", 20);

            Lapin[] tab = new Lapin[3];
            tab[0] = L1;
            tab[1] = L2;
            tab[2] = L3;

            for (int i = 0; i < 101; i++)
            {
                L1.Avancer();
                L2.Avancer();
                L3.Avancer();
            }
            Console.ReadLine();
        }
    }
}
