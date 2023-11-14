using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] lines = File.ReadAllLines("balkezesek.csv");

            List<Balkezesek> BalkezesekList = new List<Balkezesek>();

            for (int i = 1; i < lines.Length; i++)
            {
                Balkezesek Balkezesek = new Balkezesek(lines[i]);

                BalkezesekList.Add(Balkezesek);
            }

            Console.WriteLine("3. feladat:");
            Lines(BalkezesekList);

            Console.WriteLine("4. feladat:");
            Datas(BalkezesekList);

    
        }
        private static void Lines(List<Balkezesek> BalkezesekList)
        {
            Console.WriteLine(BalkezesekList.Count);
        }
        private static void Datas(List<Balkezesek> BalkezesekList)
        {
            DateTime dateBeginning = new DateTime(1999, 10, 01);
            DateTime dateEnd = new DateTime(1999, 10, 31);
            foreach (var baseballPlayer in BalkezesekList)
            {
                if (Balkezesek.last > dateBeginning && Balkezesek.last < dateEnd)
                {
                    Console.WriteLine(Balkezesek.name + ", " + String.Format("{0:0.0}", Balkezesek.height * 2.54) + " cm");
                }
            }
        }

    }
}