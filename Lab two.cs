using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {


        static void Main(string[] args)
        {
            int response;
            Console.WriteLine("Enter Number between 1 and 100");
            response = Convert.ToInt32(Console.ReadLine());
            if (response % 2 == 0)
            {
                Console.WriteLine(response + " is even");
            }
            else
            {
                Console.WriteLine(response + " and odd");
            }
            Console.WriteLine("Would you like to Continue y or n?");
            string response1 = Console.ReadLine();
            if (response1 == "y")

                Console.WriteLine("Enter Number between 1 and 100");
            int response2 = Convert.ToInt32(Console.ReadLine());
            if (response2 % 2 == 0 && response2 >= 2 && response2 <= 25)
            {
                Console.WriteLine("Entered number is even and less than 25");
            }
            else
            {
                Console.WriteLine("Entered number is odd");

            }
            Console.WriteLine("Would you like to Continue y or n?");
            string response3 = Console.ReadLine();
            if (response3 == "y")
            
                Console.WriteLine("Enter Number between 1 and 100");
                response = Convert.ToInt32(Console.ReadLine());
                if (response % 2 == 0 && response >= 26 && response <= 60)
                    Console.WriteLine("Even");
            
                else

                Console.WriteLine("odd");
                Console.WriteLine("Would you like to Continue y or n?");
                string response4 = Console.ReadLine();
                if (response4 == "y")

                    Console.WriteLine("Enter Number between 1 and 100");
                response = Convert.ToInt32(Console.ReadLine());
                if (response % 2 == 0&& response>60)
                {
                    Console.WriteLine(response + "is even");
                }
                else
                {
                    Console.WriteLine(response + "is odd");
                }
                Console.WriteLine("Would you like to Continue y or n?");
                string response5 = Console.ReadLine();
                if (response5 == "y")
                {
                        Console.WriteLine("Enter Number between 1 and 100");
                        response = Convert.ToInt32(Console.ReadLine());
                        if (response % 1 == 0 && response >= 60)
                        {
                            Console.WriteLine(response + " is odd");

                        }
                        else

                            Console.WriteLine(response + " is even");
                    }
                    Console.ReadKey();
                }

            }
        }
    


                            
                            
                        
                   
                
            

            
        
       
           
          


            
      
 
