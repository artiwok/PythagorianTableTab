using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PythagorianTableTab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first horizontal range number: ");
            int firstHorizNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter last horizontal range number: ");
            int lastHorizNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter first vertical range number: ");
            int firstVertNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter last vertical range number: ");
            int lastVertNum = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = firstVertNum; i <= lastVertNum; i++)
            {
                Console.Write($"\t{i}");
            }

            Console.WriteLine();

            for (int i = firstVertNum; i <= lastVertNum; i++)
            {
                Console.Write("\t-");
            }

            Console.WriteLine();

            for (int i = firstHorizNum; i <= lastHorizNum; i++)
            {
                Console.Write(i + "|");
                for (int j = firstVertNum; j <= lastVertNum; j++)
                {
                    Console.Write($"\t{i * j}");
                }

                Console.WriteLine();

            }
        }
    }
}
