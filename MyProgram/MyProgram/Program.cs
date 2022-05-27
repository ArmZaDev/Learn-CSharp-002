using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {    /*    
            //output 💬
            Console.Write("Hey!");
            Console.WriteLine("Hello!");

            //This is a comment
            /*
             * this
             * a
             * multiline
             * comment
            
            
            Console.WriteLine("Kei\nsuke");
            Console.ReadKey();
            */

            /*
            //variables ✖️
            int x; //declaration ประกาศตัวแปร
            x = 123; // initialization กำกนดค่าเริ่มต้น

            int y = 321; //declaration + initialization
            int z = x + y; 
            int age = 21; //whole integer
            double height = 300.5; //decimal number
            bool alive = true;
            char symbol = '@';
            string Yo = "Bro";

            Console.WriteLine("your age is " + age);
            Console.WriteLine("Your height is " + height + "cm");
            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("Your symbol is " + symbol);

            string userName = symbol + Yo;
            Console.WriteLine("Your username is: " + userName);
            Console.ReadKey();



            
            //constants π
            //Constants = immutable values which are known at compile time
            //            and do not chagne for the life of the program
            const double pi = 3.14159;
            Console.WriteLine(pi);
            Console.ReadKey();



            
            //type casting 💱
            //type casting = Converting a value to a different data type
            //               Useful when we accept user input (string)
            //               Different data type can do different things
            double myDoublea = 3.14;
            int myInta = Convert.ToInt32(myDoublea); //.GetType

            int myIntb = 123;
            double myDoubleb = Convert.ToInt32(myIntb);

            int myIntc = 321;
            string myStringa = Convert.ToString(myIntc);

            string myStringb = "$";
            char myChara = Convert.ToChar(myStringa);

            string myStringc = "true";
            bool myBoola = Convert.ToBoolean(myStringc);

            Console.WriteLine(myInta);
            Console.WriteLine(myDoublea);
            Console.WriteLine(myStringa);
            Console.WriteLine(myChara);
            Console.WriteLine(myBoola);
            Console.ReadKey();



            //user input ⌨️
            Console.Write("Wht's your name?");
            string name = Console.ReadLine();
            Console.Write("What's your age?");
            int Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name);
            Console.WriteLine("Your " + Age + " years old");
            Console.ReadKey();



            //arithmetic operators 🧮
            int friends = 5;
            //friends = friends + 2;
            friends += 2; //friends = friends + 2;
            //friends++;

            //friends = friends - 1;
            //friends -= 1;
            //friends--;

            //friends = friends * 2;
            //friends *= 2;

            //friends = friends / 2;
            //friends /= 2;

            //friends = friends % 2;
            //friends %= 2;

            int remainder = friends % 2;
            Console.WriteLine(remainder);
            Console.ReadKey();



            //Math class 📏
            double doublex = 0;
            
            //doublex = Math.Pow(10,2);
            //doublex = Math.Sqrt(100.00);
            //doublex = Math.Abs(-100);
            //doublex = Math.Round(100.00);
            //doublex = Math.Ceiling(100.00);
            //doublex = Math.Floor(100.00);
            //doublex = Math.Max(100, 2);
            //doublex = Math.Min(100, 2);
            
            Console.WriteLine(doublex);



            //random numbers 🎲
            Random random = new Random();
            int num1 = random.Next(1,7);
            int num2 = random.Next(1, 7);
            int num3 = random.Next(1, 7);

            //double num = random.NextDouble();

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);                        
            Console.ReadKey();
            


            //hypotenuse calculator program 📐
            //input
            Console.Write("Enter sid A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter sid B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            //process
            double c = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine("The hypotenuse is: " + c);
            Console.ReadKey();
            


            //string methods 🔤
            string fullName = "noodle";
            string phoneNumber = "123-456-7890";

            //fullName = fullName.ToUpper();
            //fullName = fullName.ToLower();
            //Console.WriteLine(fullName);

            //phoneNumber = phoneNumber.Replace("-", "/");
            //Console.WriteLine(phoneNumber);

            //string userName = fullName.Insert(0, "Mr.");
            //Console.WriteLine(userName);

            //Console.WriteLine(fullName.Length);

            string firstName = fullName.Substring(0, 3);
            string lastName = fullName.Substring(3, 3);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.ReadKey();
            


            //if statements 🤔
            Console.Write("Please enter your age: ");
            int Age0 = Convert.ToInt32(Console.ReadLine());

            if (Age0 >= 18)
            {
                Console.WriteLine("You are now signed up!");
            }
            else if (Age0 > 60)
            {
                Console.WriteLine("You are too old to signed up!");
            }
            else if (Age0 < 0)
            {
                Console.WriteLine("You haven't been born yet!");
            }
            else
            {
                Console.WriteLine("You must be 18+ to sign up!");
            }
            Console.ReadKey();

            //if statements 🤔
            Console.Write("Please enter your name: ");
            string name1 = Console.ReadLine();

            if (name1 == "")
            {
                Console.WriteLine("Youb did not enter your name!");
            }
            else
            {
                Console.WriteLine("Hello " + name1);
            }
            Console.ReadKey();
            


            //switches 🔀
            Console.Write("What day is it today? ");
            string day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("It's Monday!");
                    break;
                case "Tuesday":
                    Console.WriteLine("It's Tuesday!");
                    break;
                case "Wednesday":
                    Console.WriteLine("It's Wednesday!");
                    break;
                case "Thursday":
                    Console.WriteLine("It's Thursday!");
                    break;
                case "Friday":
                    Console.WriteLine("It's Friday!");
                    break;
                case "Saturday":
                    Console.WriteLine("It's Saturday!");
                    break;
                case "Sunday":
                    Console.WriteLine("It's Sunday!");
                    break;
            }
            Console.ReadKey();
            


            
            // logical operators && || 🔣
            // logical operators = Can be used to check if more than 1 condition is true/false

            Console.Write("What's the temperature outside: (C)");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 10 && temp <= 25) //10 ~ 25 จริงทั้งคู่
            {
                Console.WriteLine("It's warm outside!");
            }
            else if (temp <= -50 || temp >= 50) //อย่างใด อย่างหนึ่งเป็นจริงทำในปีกกา 
            {
                Console.WriteLine("DO NOT GO OUTSIDE!");
            }
            Console.ReadKey();
            


            
            //while loops ♾️
            //while loop = repeats some code while some condition remains true

            Console.Write("Enter your name: ");
            string name2 = Console.ReadLine();
            //string = ""; // is good

            while (name2 == "")
            {
                Console.Write("Enter your name: ");
                name2 = Console.ReadLine();
            }
            Console.WriteLine("Hello" + name2);
            Console.ReadKey();
            


            
            //for loops 🔁
            //for loop = repeats some code a FINITE amount of times
            /*
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            //
            for (int i = 10; i > 0; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("HAPpy NEW YEAR!");
            Console.ReadKey();
            


            
            //nested loops ➿
            //nested loops = loops inside of other loops
            //               Users vary. Used a lot in sorting algorithms

            Console.Write("How many rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many columns?: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            Console.Write("What symbol: ");
            string symBoi = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(symBoi);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            


            //number guessing game 🔢
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess, number, guesses;
            string respones;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                respones = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);   

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is to high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is to low!");
                    }
                    guess++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("Guess: " + guess);

                Console.WriteLine("Would you like to play again (Y/N): ");
                respones = Console.ReadLine();
                respones = respones.ToUpper();

                if (respones == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }

            }
            Console.WriteLine("Thanks for playing! ... I guess");
            Console.ReadKey();
            

            
            //rock-paper-scissors game 🗿
            Random random2 = new Random();
            bool PlayAgain = true;
            string player, computer;
            string answer;

            while (PlayAgain)
            {
                player = "";
                computer = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }
                
                switch (random2.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "SCISSORS")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                }

                Console.Write("Would you like to play again (Y/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    PlayAgain = true;
                }
                else
                {
                    PlayAgain = false;
                }
            }
            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();
            


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
            


            
            //arrays 🚗
            //array = a variable that can store multiple values. fixed size

            string[] cars = new string[3];
            
            //string[] cars = { "BMW", "Mustang", "Corvette" };
            cars[0] = "Teala"; //update
            cars[1] = "Mustang";
            cars[2] = "Corvette";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            //Console.WriteLine(cars[0]);
            //Console.WriteLine(cars[1]);
            //Console.WriteLine(cars[2]);
            Console.ReadKey();
            


            
            //foreach loop ➰
            //foreach loop = a simpler way to iTerate over an array, but it's less flexible
            string[] car2 = { "BMW", "Mustang", "Corvette" };

            foreach (string car in car2)
            {
                Console.WriteLine(car);
            }
            Console.ReadKey();
            



            //methods 📞
            //method = performs a section of code, whenever it's called "invoked".
            //         benefit = Let's us reuse code w/o waiting in multiple times

            //method singHappyBirthday
            string birthdayBoy = "noodle";
            int yearsOld = 21;
            singHappyBirthday(birthdayBoy, yearsOld);
            
            Console.ReadKey();
            



            //return keyword ↩️
            //return = returns data back to the place where a method is invoked

            //method Multiply
            double Op1, Op2;
            double Result;

            Console.Write("Enter in number 1: ");
            Op1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter in number 2: ");
            Op2 = Convert.ToDouble(Console.ReadLine());

            Result = Multiply(Op1, Op2);
            Console.WriteLine(Result);

            Console.ReadKey();
            



            //method overloading 🤯
            //method overloading = method share same name, but different parameters
            //                     name + parameters = signature
            //                     methods must have a uinque signature
            double total;

            total = Multiply(2, 3, 4);

            Console.WriteLine(total);
            Console.ReadKey();  
            */



            //params keyword ⚙️
            //params keyword = a mothod parameter that takes a variable number of arguments.
            //                 The parameter type mustb be a single - dimensional array

            double Total = CheckOut(3.99, 5.75, 15);

            Console.WriteLine(Total);
            Console.ReadKey();
        }

        //method singHappyBirthday
        static void singHappyBirthday(string name, int age)
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear " + name);
            Console.WriteLine("You are " + age + " years old!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine();
        }

        //method Multiply
        static double Multiply(double x, double y) 
        {
            return x * y;
            //double z = x * y;
        }
        
        /* mathods share same name
        static double Multiply(double a, double b)
        {
            return a * b;
        }
        */
        //method overloading
        static double Multiply(double a, double b, double c)
        {
            return a * b;
        }

        //params keyword
        static double CheckOut(params double[] prices)
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }
            return total;
        }
    }
}
