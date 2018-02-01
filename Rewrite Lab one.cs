using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Program
    {
    }

namespace ConsoleApp32_Redo_Lab_1
    {
        class Program
        {
            static void Main(string[] args)

            {
                int length;
                int width;
                int height;
                int perimeter;
                int volume;
                int area;





                {



                }
                try
                {


                    Console.WriteLine(" Room Detail Generator");
                    Console.WriteLine("Please enter the Dimensions of the Room");
                    Console.WriteLine("What is the length?");
                    length = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is the width?");
                    width = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is the height?");
                    height = Convert.ToInt32(Console.ReadLine());
                    perimeter = (length * 2) + (width * 2);
                    area = (length * width);
                    volume = (length * width * height);
                    Console.WriteLine("Area is = {0} Perimeter is ={1} Volume is ={2}", area, perimeter, volume);
                    Console.Write("Would you like to measure another room? y or n");
                    String response = ("");
                    while (response == "y")


                        if (response == "y")
                        {
                            Console.Write("Would you like to measure another room? y or n");
                        }
                        else
                        {
                            Console.ReadLine();
                        }
                }
                catch
                {












                }
            }
        }
    }

}
  
