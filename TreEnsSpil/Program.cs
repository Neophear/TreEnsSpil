using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreEnsSpil
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n1;
            int n2;
            int n3;
            int saldo = 10;

            while (true)
            {
                Console.Clear();
                n1 = rnd.Next(1, 7);
                n2 = rnd.Next(1, 7);
                n3 = rnd.Next(1, 7);

                Console.WriteLine($"{n1} - {n2} - {n3}");
                if (n1 == n2 && n2 == n3)
                {
                    saldo += 5;
                    Console.WriteLine("Hurray! Take theese $5");
                }
                else
                {
                    saldo--;
                    Console.WriteLine("Buuh! We take $1");
                }
                Console.WriteLine($"Saldo: {saldo}");

                if (saldo == 0)
                    Console.WriteLine("Game over!");

                Console.ReadKey();
            }
        }
    }
}
