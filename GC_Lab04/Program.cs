using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;

            while (cont == true)
            { 
                Console.WriteLine("Give me a number");
                int num = int.Parse(Console.ReadLine());

                Console.WriteLine("Number" + "\t" + "Squared" + "\t" + "Cubed");
                Console.WriteLine("===== \t ===== \t =====");
                Console.WriteLine(Math.Pow(num, 1) + "\t" + Math.Pow(num, 2) + "\t" + Math.Pow(num, 3));

                Console.WriteLine("Continue? (y/n)");
                string ans = Console.ReadLine();
                if (ans == "n") { cont = false; }
            }
        }
    }
}
