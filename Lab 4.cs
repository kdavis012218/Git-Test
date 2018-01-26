using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, number, factorial;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("{{{{{{{{{{{{{{{{{{{{{{{{{{{{{");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("       BOOT CAMP LAB 4 ");
            Console.WriteLine("     FACTORIAL CALCULATOR ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("{{{{{{{{{{{{{{{{{{{{{{{{{{{{{");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Enter an integer greater than 0 but less than ten");
            number = int.Parse(Console.ReadLine());
            factorial = number;
            for (a = number - 1; a >= 1; a--)
            {
                factorial = factorial * a;
            }
            Console.WriteLine("\nFactorial is: " + factorial);
            bool run = true;
            int n = 0;
            while (run == true)

            {

                Console.WriteLine(n);
                n++;
                if (n >= 10)
                    break;
                {
                    Console.WriteLine("Would you like to Continue y or n?");
                    string response1 = Console.ReadLine();
                    if (response1 == "y")
                        continue;

                    else
                    {
                        break;


                    }
                }
            }
        }
    }
}

       
