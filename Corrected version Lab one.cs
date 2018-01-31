using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus Room Detail Generator");




            float Area;
            float Perimeter;
            float Volume;
            
            Console.Write("Enter Length: ");
            float length = float.Parse(Console.ReadLine());
            Console.Write("Enter Width: ");
            float width = float.Parse(Console.ReadLine());
            Console.Write("Enter Height: " +
                "");
            float height = float.Parse(Console.ReadLine());
            Area = length * width;
            Perimeter = (length * 2) + (width * 2);
            Volume = length * width * height;



            Console.WriteLine("Area is " + Area);
            Console.WriteLine("Perimeter is " + Perimeter);
            Console.WriteLine("Volume is " + Volume);
            Console.WriteLine("Would you like to Continue y or n?");
            string response = Console.ReadLine();
            if (response == "y")
            {
                Console.Write("Enter Length: ");
                float length1 = float.Parse(Console.ReadLine());
                Console.Write("Enter Width: ");
                float width1 = float.Parse(Console.ReadLine());
                Console.Write("Enter Height: ");
                float height1 = float.Parse(Console.ReadLine());
                Area = length1 * width1;
                Perimeter = (length1 * 2) + (width1 * 2);
                Volume = length1 * width1 * height1;



                Console.WriteLine("Area is " + Area);
                Console.WriteLine("Perimeter is " + Perimeter);
                Console.WriteLine("Volume is " + Volume);
                Console.WriteLine("Would you like to Continue y or n?");
                string response1 = Console.ReadLine();
                if (response1 == "y")

                {


                }
            }
                        else
            {
                Console.ReadKey();

            }

        }



    }
}
    

