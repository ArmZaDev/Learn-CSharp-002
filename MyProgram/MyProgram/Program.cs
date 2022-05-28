using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {      
            //output 💬
            Console.Write("Hey!");
            Console.WriteLine("Hello!");

            //This is a comment
            /*
             * this
             * a
             * multiline
             * comment
            */
            
            Console.WriteLine("Kei\nsuke");
            Console.ReadKey();
            

            
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
            */
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
            Random randomm = new Random();
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
            



            //params keyword ⚙️
            //params keyword = a mothod parameter that takes a variable number of arguments.
            //                 The parameter type mustb be a single - dimensional array

            //Method Checkout 
            
            double Total = CheckOut(3.99, 5.75, 15);

            Console.WriteLine(Total);
            Console.ReadKey();
            



            //exception handling ⚠️
            //exception = error that occur during excution

            //        try     = try some code that is considered "dangerous"
            //        catch   = catches and handles exception when they occur
            //        finally = always executes regardless if exception is caught or not

            double x, y;
            double resultout;

            try
            {
                Console.Write("Enter number 1: ");
                x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                y = Convert.ToDouble(Console.ReadLine());

                resultout = x / y;

                Console.WriteLine("result = {0}", resultout);
            } 
            catch (FormatException e)
            {
                Console.WriteLine("Enter ONLY numbers PLEASE!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by zero!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!");
            }
            finally
            {
                Console.WriteLine("Thanks for visiting!");
            }
            Console.ReadKey();
            



            //conditional operator ❓
            //conditional operator = used in conditional assignment if a condition is true/false

            // (condition) ? x1 : y1
            double temperature = 20;
            string message;
            //-----------------------------
            message = (temperature >= 15) ? "It's warm outside!" : "It's cold outside!";
            Console.WriteLine(message); 
            
            if (temperature >= 15)
            {
                message = "It's warm outside!";
            }
            else
            {
                message = "It's cold outside!";
            }
            Console.WriteLine(message);
            Console.ReadKey();
            



            //string interpolation 💲
            //string interpolation = allows us to insert variables into a string Literal
            //                       precede a string Literal with $
            //                       {} are placeholders

            string firstName = "sushi";
            string lastName = "raman";
            int agenum = 21;

            Console.WriteLine($"Hello {firstName} {lastName}.");
            Console.WriteLine($"You are {agenum, 5} years old.");
            Console.ReadKey();

            //Console.WriteLine("Hello " + firstName + " " + lastName + ".");
            //Console.WriteLine("You are " + agenum + " years old.");
            



            //multidimensional arrays ⬜
            string[] ford = { "Mustang", "F-150", "Explorer" };
            string[] chevy = { "Corvette", "Camaro", "Silverado" };
            string[] toyota = { "Corolla", "Camry", "Rav4" };

            string[,] parkinglot = { { "Mustang", "F-150", "Explorer" },
                                     { "Corvette", "Camaro", "Silverado" },
                                     { "Corolla", "Camry", "Rav4" } };

            parkinglot[0, 2] = "Fusion";
            parkinglot[2, 0] = "Tacoma";
            /*
            //---------
            foreach (string car in parkinglot)
            {
                Console.WriteLine(car);
            }
            //----------
            */
            for (int i = 0; i < parkinglot.GetLength(0); i++)
            {
                for (int j = 0; j < parkinglot.GetLength(1); j++)
                {
                    Console.Write(parkinglot[i, j] + " ");
                }
            }
            Console.ReadKey();
            




            //classes 📦
            //classes = A boudle of related code.
            //          Can be used as a blueprint to creat objects (OOP)

            //class Messages
            Messages.Hello();
            Messages.Waiting();
            Messages.Bye();

            Console.ReadKey();
         




            //objects 🧍‍♂️
            //objects = An instance of a class
            //          a class can be used as a blueprint to create objects (OOP)
            //          object can have fields & method (characteristics & actions)

            //class Human
            Human human1 = new Human();
            Human human2 = new Human();

            human1.name = "sashimi";
            human1.age = 24;

            human2.name = "Morty";
            human2.age = 16;

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();

            Console.ReadKey();
            




            //constructors 👷
            //constructors = A special method in a class 
            //               Same name as the class name
            //               Can be used to assign arguments to fields when creating an object
            
            Car car1 = new Car("Ford", "Mustang", 2022, "red");
            Car car2 = new Car("Chevy", "Corvette", 2021, "blue");
            
            car1.Drive();
            car2.Drive();
            Console.ReadKey();


            
            //-----------------
            Human human1 = new Human("sashimi", 26);
            Human human2 = new Human("Morty", 16);

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();

            Console.ReadKey();
            
            //-------------------




            //static 🚫
            //static = modifier to declare a static member, which belongs to the class isself
            //         rather than to any specific object

            //class cars static
            Cars carone = new Cars("Mustang");
            Cars cartwo = new Cars("Corvette");

            Console.WriteLine(Cars.numberOfcar);
            Cars.StartRace();
            Console.ReadKey();
            




            //overloaded constructors 🍕
            //overloaded constructors = technique to creat multiple contructors,
            //                          with a different set of parameters.
            //                          name + parameters = signature

            //class Pizza
            Pizza pizza = new Pizza("stuffed crust", "red sauce", "mozzarella");

            Console.ReadKey();
            




            // inheritance 👪
            // inheritance = 1 or more child class recieving fields, method, etc. from a common parent

            //class Vehicle
            CarA car = new CarA();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);
            car.go();

            Console.WriteLine(bicycle.speed);
            Console.WriteLine(bicycle.wheels);
            bicycle.go();

            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.wheels);
            boat.go();

            Console.ReadKey();
            



            //abstract classes 👻
            //abstract classes = modifier that indicates missing components or incomplete implementation

            //class Vehicle2
            Car2 car2 = new Car2();
            Bicycle2 bicycle2 = new Bicycle2();
            Boat2 boat2 = new Boat2();
            
            Console.ReadKey();
            



            //array of objects 🏬
            //class Car array of objects 
            /*
            //----------------------------
            Car[] garage = new Car[3];

            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");
            Car car3 = new Car("Lambo");

            garage[0] = car1;
            garage[1] = car2;
            garage[2] = car3;
            //----------------------------
            */

            Car[] garage = { new Car("Mustang"), new Car("Corvette"), new Car("Lambo") };
        
            foreach (Car car in garage)
            {
                Console.WriteLine(car.model);
            }
            Console.ReadKey();
            




            //objects as arguments 🧳
            //Car objects as arguments

            Car car1 = new Car("Mustang", "red");

            Car car2 = Copy(car1);

            Console.WriteLine(car1.color + " " + car1.model);
            Console.ReadKey();
            



            //method overriding 🙅
            //method overriding = provides a new version of a method inherited from a parent class
            //                    inherited method must be: abstract, virtual, or already overriden
            //                    Used with ToString(), polymorphism

            //class method overriding
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();

            Console.ReadKey();
            



            //ToString method 💭
            //ToString method = converts an object to its string representation so that it is suitable for display

            //class Car ToString method
            Car car = new Car("Chevy", "Corvette", 2022, "blue");

            Console.WriteLine(car.ToString());
            Console.ReadKey();
            



            //polymorphism 🎭
            //polymorphism = Greek word that meens to "have many forms"
            //               Objects can be identified by more than one type
            //               Ex. A Dog is also: Canine, Animal, Organism

            //calss Vehicle polymorphism
            Car1 car = new Car1();
            Bicycle1 bicycle = new Bicycle1();
            Boat1 boat = new Boat1();

            Vehicle3[] vehicles = { car, bicycle, boat };

            foreach (Vehicle3 vehicle in vehicles)
            {
                vehicle.Go();
            }

            Console.ReadKey();
            



            //interfaces 🐟
            //interfaces = defines a "constract" that all the classes inheriting from should follow

            //             An interface declares "what a class should have"
            //             An inheriting class dedfines "how it should do it"
            //             Benefit = security + multiple inheritance + "plug-and-play"

            //class interface
            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();

            hawk.Hunt();
            rabbit.Flee();
            fish.Hunt();
            fish.Flee();
            Console.ReadKey();
            



            //Lists 📃
            //List = data structure that represents a list of objects that can be accessed by index.
            //       Similar to array, but can dynamically increase/decrease in size
            //       using System.Collections.Generic;

            List<string> food = new List<string>();

            food.Add("fries");
            food.Add("pizza");
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("fries");

            //food.Remove("fries");
            //food.Insert(0, "sushi");
            //Console.WriteLine(food.Count);
            //Console.WriteLine(food[0]);
            //Console.WriteLine(food.IndexOf("pizza"));
            //Console.WriteLine(food.LastIndexOf("fries"));
            //Console.WriteLine(food.Contains("pizza"));
            //food.Sort();
            //food.Reverse();
            //food.Clear();
            //string[] foodArray = food.ToArray();    

            foreach (string item in food) //foodArray
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            



            //List of objects 🦸‍♂️
            //class Player List of objects

            List<Player> players = new List<Player>();

            players.Add(new Player("chad"));
            players.Add(new Player("steve"));
            players.Add(new Player("gigi"));

            foreach (Player player in players)
            {
                Console.WriteLine(player);
            }
            Console.ReadKey();
            



            //getters & setters 🔒
            //getters & setters = add security to fields by encapsulation
            //                    They're accessors found within properties

            // properties = combine aspects of both fields and methods (share name with a field)
            // get accessor = used to return the property value
            // get accessor = used to assign a new value
            // value keyword = defines the value being assigned by the set (parameter)

            //class CarSpeed getters & setters

            CarSpeed car = new CarSpeed(400);

            car.Speed = 1000000000;

            Console.WriteLine(car.Speed);
            Console.ReadKey();
            




            //auto implemented properties 🔐
            //auto implemented properties = shortcut when no additional logic is required in thr property
            //                              you do not have to define a field for a property,
            //                              you only have to write get; and/or set; inside the property

            //class CarModel auto implemented properties
            CarModel car = new CarModel("Parche");

            Console.WriteLine(car.Model);
            Console.ReadKey();
            



            //enums 🪐
            //enums = special "class" rhat contains a est of named integer constants.
            //        Use enums when you have values that you know will not change,
            //        To get integer value from an item, you must explicily convert to an int

            //        name = integer

            //Console.WriteLine(Planets.Mercury + " is planet #" + (int)Planets.Mercury);
            //Console.WriteLine(Planets.Pluto + " is planet #" + (int)Planets.Pluto);

            string nameP = PlanetRadius.Earth.ToString();
            int radius = (int)PlanetRadius.Earth;
            double volume = Volume(PlanetRadius.Earth);

            Console.WriteLine("planet: " + nameP);
            Console.WriteLine("radius: " + radius + "km");
            Console.WriteLine("Volume: " + volume + "km^3"); 
            Console.ReadKey();
            



            //generics ⁉️
            //generics = "not specific to a paricular data type"
            //            add <T> to: classes, method, field, ect.
            //            allows for code reusability for different data types

            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            string[] stringArray = { "1", "2", "3" };

            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);
            Console.ReadKey();
            



            //multithreading 🧶
            //thread = an execution path of a program
            //         We can use multiple threads to perform,
            //         different tasks to our program at the same time.
            //         using System.Thraeding;

            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "main Thread";
            //Console.WriteLine(mainThread.Name);
            //Thread thread1 = new Thread(CountDown);
            //Thread thread2 = new Thread(CountUp);

            Thread thread1 = new Thread(() => CountDown("Timer #1"));
            Thread thread2 = new Thread(() => CountUp("Timer #2"));
            thread1.Start();
            thread2.Start();

            //CountDown();
            //CountUp();

            Console.WriteLine(mainThread.Name + " is complete!");
            Console.ReadKey();




            //--------------------------------------------------
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
        /*
        //Car objects as arguments
        public static Car Copy(Car car)
        {
            return new Car(car.model, car.color);
        }
        */

        //---------------------------------------------------------- 

        //enums Planet
        public static double Volume(PlanetRadius radius)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
            return volume;
        }

        //------------------------------------------------------------

        //generics 
        public static void displayElements<Thing>(Thing[] array)
        {
            foreach (Thing item in array)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
        }
        /*
        public static void displayElements(double[] array)
        {
            foreach (double item in array)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
        }
        public static void displayElements(string[] array)
        {
            foreach (string item in array)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
        }
        */

        //----------------------------------------------------------

        //multithreading
        public static void CountDown(string name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 is complete!");
        }
        public static void CountUp(string name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 is complete!");
        }
    }

    //class Human
    class Human
    {
        public string name;
        public int age;

        /*
        //constructors
        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        */

        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }

    //------------------------------------------------------
    
    //class Car
    class Car
    {
        string make, model;
        int year;
        string color;
        public Car(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }
        public void Drive()
        {
            Console.WriteLine("You drive the " + make + " " + model);
        }
    }
    
    //------------------------------------------------------
    
    //class Car Array of objects
    class Car
    {
        public string model;

        public Car(string model)
        {
            this.model = model;
        }
    }
    
    //------------------------------------------------------
    
    //class Car  objects as arguments
    class Car
    {
        public string model;
        public string color;

        public Car(string model, string color)
        {
            this.model = model;
            this.color = color;
        }
    }
    
    //-----------------------------------------------------

    //class Cars static
    class Cars
    {
        string model;
        public static int numberOfcar;

        public Cars(string modle)
        {
            this.model = modle;
            numberOfcar++;
        }
        public static void StartRace()
        {
            Console.WriteLine("The race has begun!");
        }       
    }

    //------------------------------------------------------
    //class method overriding
    class Animal
    {
        public virtual void Speak()  // virtual
        {
            Console.WriteLine("The animal goes *brrr*");
        }
    }
    class Dog : Animal
    {
        public override void Speak()  // override
        {
            Console.WriteLine("The dog goes *woof*");
        }
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The cat goes *meow*");
        }
    }
    //--------------------------------------------------------

    //class Car ToString method
    class Car
    {
        string make, model;
        int year;
        string color;
        public Car(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }
        public override string ToString()
        {
            return "This is a " + make + " " + model;
        }
    }

    //calss Vehicle polymorphism
    class Vehicle3
    {
        public virtual void Go()
        {
            Console.WriteLine("The car is moving");
        }
    }
    class Car1 : Vehicle3
    {
        public override void Go()
        {
            Console.WriteLine("The car is moving!");
        }
    }
    class Bicycle1 : Vehicle3
    {
        public override void Go()
        {
            Console.WriteLine("The bicycle is moving!");
        }
    }
    class Boat1 : Vehicle3
    {
        public override void Go()
        {
            Console.WriteLine("The boat is moving!");
        }
    }

    //class interface
    interface IPrey 
    {
        void Flee();
    }
    interface IPredetor
    {
        void Hunt();
    }
    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit runs away!");
        }
    }
    class Hawk : IPredetor
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk is runs searching for food!");
        }
    }
    class Fish : IPrey, IPredetor
    {
        public void Flee()
        {
            Console.WriteLine("The fish swims away!");
        }
        public void Hunt()
        {
            Console.WriteLine("The fish is searching for smaller fish");
        }
    }

    //enums
    enum Planets
    {
        Mercury = 1,
        Venus = 2,
        Earth = 3,
        Mars = 4,
        Jupiter = 5,
        Saturn = 6,
        Uranus = 7,
        Neptune = 8,
        Pluto = 9
    }
    enum PlanetRadius
    {
        Mercury = 2439,
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25326,
        Neptune = 24622,
        Pluto = 1188
    }
}
