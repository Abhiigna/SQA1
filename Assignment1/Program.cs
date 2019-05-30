using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        public static void Main(String[] arg)
        {
            Rectangle rec = new Rectangle();
            try
            {
                while (true)
                {
                    Console.WriteLine("1.Get Rectangle Length\n2.Change Rectangle Lenth\n3.Get Rectangle width\n4.Change Rectangle Width");
                    Console.WriteLine("5.Get Rectangle perimeter\n6.Get Rectengle Area\n7. Exit");

                    Console.WriteLine("Enter your choice:");
                    string option = Console.ReadLine();
                    if (option == "7")
                    {
                        break;
                    }

                    switch (option)
                    {
                        case "1":
                            Console.WriteLine("Length of Rectangle :{0}", rec.GetLength());
                            break;
                        case "2":
                            int number = 1;
                            bool isValid = false;
                            string length = "";

                            while (isValid == false)
                            {
                                Console.WriteLine("Please enter the length of your rectangle:");
                                length = Console.ReadLine();
                                Console.WriteLine();

                                bool result = int.TryParse(length, out number);

                                if (result == false)
                                {
                                    Console.WriteLine("Invalid Input, please try again.\n");
                                }
                                else if (number < 0) 
                                {
                                    Console.WriteLine("Number is less than 0, please give a number greater than 0.\n");
                                }
                                else
                                {
                                    isValid = true;
                                }
                                 rec.SetLenght(number);
                            }
                           

                            break;
                        case "3":
                            Console.WriteLine("Width of Rectangle :{0}", rec.GetWidth());
                            break;
                        case "4":
                            int number1 = 1;
                            bool isValidwidth = false;

                            while (isValidwidth == false)
                            {
                                Console.WriteLine("Please enter the width of your rectangle:");
                                string width = Console.ReadLine();
                                Console.WriteLine();

                                bool result = int.TryParse(width, out number1);

                                if (result == false)
                                {
                                    Console.WriteLine("Invalid Input, please try again.\n");
                                }
                                else if (number1 < 0)
                                {
                                    Console.WriteLine("Number is less than 0, please give a number greater than 0.\n");
                                }
                                else
                                {
                                    isValidwidth = true;
                                }
                                rec.SetWidth(number1);
                            }

                            break;
                        case "5":
                            Console.WriteLine("Perimeter of Rectangle :{0}", rec.GetPerimeter());
                            break;
                        case "6":
                            Console.WriteLine("Area of Rectangle :{0}", rec.GetArea());
                            break;
                        
                    }
                    
                }
            }
            catch(Exception ae)
            {
                Console.WriteLine("invalid input",ae);
            }

        }
    }
}
