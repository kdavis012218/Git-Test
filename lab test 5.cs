using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("{{{{{{{{{{{{{{{{{{{{{{{{{{{{{");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("       BOOT CAMP LAB 5 ");
            Console.WriteLine("      HI-ROLLER DICE SIM ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("{{{{{{{{{{{{{{{{{{{{{{{{{{{{{");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Random randNum = new Random();
            int rollNum = 1;
            int die1;
            int die2;
            int response;
            for (rollNum = 1; rollNum < 20; rollNum++)
            {
                Console.WriteLine("Enter Number Of Sides");
                response = Convert.ToInt32(Console.ReadLine());
                if (response < 2)
                    break;
                

                die1 = randNum.Next(minValue: 1, maxValue:response);
                die2 = randNum.Next(minValue: 1, maxValue: response);
                Console.WriteLine(value: "Roll " + rollNum + ": " + die1 + " " + die2);
                if (die1==die2)
                    Console.Write("Double UP! ");
                if (die1 == 1 && die2 == 1)
                    Console.Write("SNAKE EYES");

                    
                    Console.WriteLine("Would you like to roll again?");
                    string response1 = Console.ReadLine();
                if (response1 == "n")
                    break;
                    {
                        
                        
                    }
                    {

                    }
                   





                }
                { }
            }
        }
    }

    

