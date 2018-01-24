using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lat3Table
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter a integer.");
                int Num = int.Parse(Console.ReadLine());
                Console.WriteLine("Number\tSquared\tCubed");
                Console.WriteLine("======\t======\t======");


                for (double i = 1; i <= Num; i++)
                {
                    double Squared = Math.Pow(i, 2);
                    double Cubed = Math.Pow(i, 3);
                    Console.WriteLine($"{i}\t{Squared}\t{Cubed}");

                }
                Console.WriteLine("Would you like me to continue? (Yes/No)");
                if (Console.ReadLine().ToLower() != "yes")
                    break;
            }
        }

        //public static int Squared(int Num)
        //{
        //    int NumSquared = Num * Num;
        //    return NumSquared;
        //}

        //public static int Cubed(int Num)
        //{
        //    int NumCubed = Num * Num * Num;
        //    return NumCubed;
        //}
    }
}
