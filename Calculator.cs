/* 
Nama : Rachmad Fajar Ramadhan
Nim: 21.11.4418
Kelas:21 IF 09
*/
using System;

namespace BasicCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Basic Calculator";
            //Declaration
            double num1 = 0, num2 = 0, result = 0;
            int menu;


        menu:
            //UI menu
            Console.Clear();
            Console.WriteLine("\t\t\tBasic Calculator\n\n");
            Console.WriteLine("Menu\n");
            Console.WriteLine("1. Addition\n");
            Console.WriteLine("2. Subtraction\n");
            Console.WriteLine("3. Multiplication\n");
            Console.WriteLine("4. Division\n");
            Console.WriteLine("5. Exit\n");

            //save the input to the variable menu
            Console.Write("Enter your menu choice: ");
            menu = Convert.ToInt32(Console.ReadLine());
            //exception
            if (menu == 5)
            {
                Console.Clear();
                Console.WriteLine("\nThank you for using this app.");
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
                //exit
                Environment.Exit(0);
            }
        //Error Handling
        input:
            Console.Clear();
            try
            {
                //Apps name
                Console.WriteLine("\t\t\tBasic Calculator\n\n");
                //input number
                Console.Write("Enter first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                Console.WriteLine("Press any key to return.");
                Console.ReadKey();
                goto input;

            }

        //switch statement
        swh:
            switch (menu)
            {
                case 1:
                    Console.Clear();
                    result = num1 + num2;
                    Console.WriteLine("\nResult: " + num1 + "+" + num2 + "=" + result);
                    Console.WriteLine("Press any key to return to menu.");
                    Console.ReadKey();
                    goto menu;

                case 2:
                    Console.Clear();
                    result = num1 - num2;
                    Console.WriteLine("\nResult: " + num1 + "-" + num2 + "=" + result);
                    Console.WriteLine("Press any key to return to menu.");
                    Console.ReadKey();
                    goto menu;
                case 3:
                    Console.Clear();
                    result = num1 * num2;
                    Console.WriteLine("\nResult: " + num1 + "x" + num2 + "=" + result);
                    Console.WriteLine("Press any key to return to menu.");
                    Console.ReadKey();
                    goto menu;
                case 4:
                    Console.Clear();
                    result = num1 / num2;
                    Console.WriteLine("\nResult: " + num1 + ":" + num2 + "=" + result);
                    Console.WriteLine("Press any key to return to menu.");
                    Console.ReadKey();
                    goto menu;

                default:
                    Console.Clear();
                    Console.WriteLine("\nInvalid menu choice.");
                    Console.WriteLine("Press any key to return.");
                    Console.ReadKey();
                    goto menu;

            }




        }
    }
}
