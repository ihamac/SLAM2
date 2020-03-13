using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace lapin
{
    class Program
    {

        static void Main()
        {
            /*
            List<Lapin> mesLapins= new List<Lapin>();

            mesLapins.Add(new Lapin("jeannot",2));
            mesLapins.Add(new Lapin("panpan", 6));
            mesLapins.Add(new Lapin("jelly", 5));

            for (int j = 0; j < 42; j++) {
                for (int i = 0; i < mesLapins.Count; i++) {
                    ((Lapin)mesLapins[i]).Avancer();
                    Console.WriteLine(mesLapins[i].ToString());
                }

            }
            Console.ReadLine();
            */

            ArrayList mesLapins = new ArrayList();
            mesLapins.Add(new Lapin("Jeannot", 2));
            mesLapins.Add(new Lapin("Panpan", 6));
            mesLapins.Add(new Lapin("Jelly", 5));

            for (int j = 0; j < 40; j++)
            {
                for (int i = 0; i < mesLapins.Count; i++)
                {
                    ((Lapin)mesLapins[i]).Avancer();
                    Console.WriteLine(((Lapin)mesLapins[i]).ToString());
                }

            }

            Lapin gagnant = (Lapin)mesLapins[0];
            foreach (Lapin lapin in mesLapins) {
                if (lapin.Position() > gagnant.Position()) {
                    gagnant = lapin;
                }
            }
            Console.WriteLine("Le gagnant est {0} !", gagnant.Surnom);
            Console.ReadLine();

            
            /*
            Lapin l1 = new Lapin("Guy",2);
            Lapin l2 = new Lapin("Matthias",3);
            Lapin l3 = new Lapin("David",4);
            Lapin[] tabL = new Lapin[3];
            tabL[0] = l1;
            tabL[1] = l2;
            tabL[2] = l3;

            for (int i = 0; i < tabL.Length; i++)
            {
                tabL[i].Avancer();
                Console.WriteLine(tabL[i].ToString());
            }

            
            Console.ReadLine();
             */

        }
    }  
}
