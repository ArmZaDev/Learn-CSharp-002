using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //calculator program 🖩
            do
            {
                double number1 = 0;
                double number2 = 0;
                double result = 0;

                Console.WriteLine("------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("------------------");

                Console.Write("Enter number 1: ");
                number1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                number2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divde");
                Console.Write("Enter an option: ");


                switch (Console.ReadLine())
                {
                    case "+":
                        result = number1 + number2;
                        Console.WriteLine($"your result: {number1} + {number2} = " + result);
                        break;
                    case "-":
                        result = number1 - number2;
                        Console.WriteLine($"your result: {number1} - {number2} = " + result);
                        break;
                    case "*":
                        result = number1 * number2;
                        Console.WriteLine($"your result: {number1} * {number2} = " + result);
                        break;
                    case "/":
                        result = number1 / number2;
                        Console.WriteLine($"your result: {number1} / {number2} = " + result); //$ ละอักขระพิเศษ
                        break;
                    default:
                        Console.WriteLine("That was not a valid option");
                        break;
                }
                Console.WriteLine("Would you like to continue? (Y = yes, N = no): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Bye!");
            Console.ReadKey();
        }
    }
}
