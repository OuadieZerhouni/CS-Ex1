using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool noprem = true;
            while(noprem)
            {
                Console.WriteLine("Entrer un nombre : ");
                string inpt = Console.ReadLine();
                int.TryParse(inpt, out int number); ;

                noprem = !Prem(number);
                if (!noprem)
                {
                    Console.WriteLine("est premier!!");
                }
            }

            Console.ReadLine();

        }
        static bool Prem(int num)
        {
            if (num < 1) return true;
            if (num == 1 | num == 2) return true;
            if (num % 2 == 0) return false;

            for (int i = 3; i < num; i += 2)
                if (num % i == 0)
                    return false;

            return true;
        }
    }
}
