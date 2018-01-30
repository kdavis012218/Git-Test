using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        
          public static object hashtable { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Student Info Simulator");
            string input = "";
            
            Console.WriteLine(" What Student would you like more info about?");
            Console.ReadLine();
            Console.WriteLine(" You May Choose From this list:");
            Console.WriteLine("Johnny Depp");
            input = Console.ReadLine();//reads input
            if (input == "Johnny Depp")
                Console.Write(" What would you like to know about Johnny? Hometown, or Fav Food?");
            input = Console.ReadLine();
            if (input == "Hometown") ; 
            
            Hashtable ht = new Hashtable();
            ht.Add(1, "Hollywood");
            ht.Add(2, "Steak");
            
            string strValue1 = (string)ht[1];
            string strValue2 = (string)ht[2];
            Console.WriteLine(strValue1);
            Console.WriteLine(strValue2);
            Console.WriteLine("Would you like more Student info?");
            input = Console.ReadLine();
            if (input == "y")
            {
                Console.ReadLine();
            }

            if (input == "Fav Food")
                Console.Write("2");
            
            
            





            //start Tom Cruise here//
            //if (input == "Tom Cruise")
            //    Console.Write(" What would you like to know about Tom? Hometown, or Fav Food?");
            //input = Console.ReadLine();
            //if (input == "Hometown")
            //    Console.Write("3");
            //if (input == "Fav Food")
            //    Console.Write("4");









            //ht.Add("3", "Tom Cruise", "Filet Mignon");
            //ht.Add("4", "Tom Cruise", "Fudge Brownies");
            //ht.Add("5", "Jet Li", "Grilled Salmon");
            //ht.Add("6", "Jet Li", "Beijing");
            //ht.Add("7", "Dwayne Johnson", "Porterhouse Steak");
            //ht.Add("8", "Dwayne Johnson", "Los Angeles, CA");
            //ht.Add("7", "Ethan Hunt", "Sushi");
            //ht.Add("8", "Ethan Hunt", "Prague");
            //ht.Add("9", "Bruce Wayne", "Poached Quail");
            //ht.Add("10", "Bruce Wayne", "Gotham City");
            //ht.Add("11", "Jason Statham", "Roast Lamb");
            //ht.Add("12", "Jason Statham", "London, England");
            //ht.Add("10", "Daniel Craig", "Chili Dogs");
            //ht.Add("10", "Daniel Craig", "New York");
            //ht.Add("10", "Pierce Brosnan", "New York");
            //ht.Add("10", "Pierce Brosnan", "New York");





        }


    }

       
       
            }
        
    


      