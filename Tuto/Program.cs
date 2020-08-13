using System;
using System.Drawing;
using System.IO;

namespace Tuto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            METHODS
            SayHi("Tony", 21);
            */

            /*
            RETURN METHODS
            int cubeNum = Cube(3);
            Console.WriteLine(cubeNum);
             */

            /*
            IF STATEMENTS
            bool isMale = false;
            bool isTall = false;

            if (isMale && isTall)
            {
                Console.WriteLine("You are male or tall");
            } else if (isMale && !isTall) {
                Console.WriteLine("You are a short male");
            } else if (!isMale && isTall) {
                Console.WriteLine("You are not male but you are tall");
            } else {
                Console.WriteLine("You are not male neither tall");
            }
            */

            /*
            IF COMPARISONS
            Console.WriteLine(GetMax(2, 32, 25));
            */

            /*
            CALCULATOR
            Console.Write("Enter number 1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter number 2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.Write(num1 + num2);
            }
            else if (op == "-")
            {
                Console.Write(num1 - num2);
            }
            else if (op == "*")
            {
                Console.Write(num1 * num2);
            }
            else if (op == "/")
            {
                Console.Write(num1 / num2);
            }
            else
            {
                Console.Write("Operador inválido");
            }
            */

            /* 
            SWITCH STATEMENTS
            Console.WriteLine(GetDay(2));
            */

            /*
            WHILE AND DO WHILE
            int index = 6;
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);
            */

            /*
            GUESSING GAME
            string secretWord = "basura";
            string guess = "";
            int guessCount = 5;

            while (guess != secretWord && guessCount != 0)
            {
                Console.WriteLine("Adivina la palabra (" + guessCount + " intentos restantes): ");
                guess = Console.ReadLine();
                guessCount--;
            }
            if (guessCount != 0)
            {
                Console.WriteLine("¡Ganaste!");
            }
            else
            {
                Console.WriteLine("GAME OVER");
            }
            */


            /*
            FOR LOOP
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            int[] luckyNumbers = { 1, 23, 12, 5, 7 };
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }
            */

            /*
             * EXPONENT FUNCTION
            Console.WriteLine(getPow(5, 3));
            */

            /*
             * ARRAYS
            int[,] numberGrid = {
                {1, 2},
                {3, 4},
                {5, 6}
            };

            int[,] myArray = new int[2, 3];

            Console.WriteLine(numberGrid[2, 1]);
            */


            /* 
            EXCEPTIONS
            try
            {
                Console.Write("Enter number 1: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number 2: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);

            }
            catch (DivideByZeroException error)
            {
                Console.WriteLine(error.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Cerrando...");
            }
            */

            /*
             // CLASSES AND OBJECTS
            //DEFINIENDO CLASE CON CONSTRUCTO
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            //DEFINIENDO CLASE SIN CONSTRUCTO
            Book book2 = new Book();
            book2.title = "Lord of the Rings";
            book2.author = "Tolkien";
            book2.pages = 700;

            Console.WriteLine(book1.title);
            */

            /*
             * OBJECTS METHODS
            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Martha", "Art", 9.8);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
            */
            /*
             * GETTERS AND SETTERS
            Movie avengers = new Movie("Avengers", "Joss Whedon", "dog");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            //Valid ratings: G, PG, PG-13, R, NR
            Console.WriteLine(avengers.Rating);
            */

            /*
             * STATIC CLASS ATTRIBUTES
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(Song.songCount);
            Console.WriteLine(holiday.artist);
            Console.WriteLine(kashmir.artist);
            Console.WriteLine(kashmir.getSongCount);
            */

            /*
            Console.WriteLine(Math.Sqrt(144));
            UsefulTools.SayHi("Tony");
            // No se puede crear una instancia
            //UsefulTools tools = new UsefulTools();
            //porque es estática
            */

            /*
             * INHERITANCE
            Chef chef = new Chef();
            chef.MakeChicken();
            
            ItalianChef italianchef = new ItalianChef();
            italianchef.MakeChicken();
            italianchef.MakePasta();
            chef.MakeSpecialDish();
            italianchef.MakeSpecialDish();
            */

            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age + " years old!");
        }

        static int Cube(int num)
        {
            int result = num * num * num;
            return result;
        }

        static int GetMax(int num1, int num2, int num3)
        {
            int result;

            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;
        }

        static string GetDay(int dayNum) {
            string dayName;
            switch (dayNum)
            {
                case 0:
                    dayName = "Lunes";
                    break;
                case 1:
                    dayName = "Martes";
                    break;
                case 2:
                    dayName = "Miércoles";
                    break;
                case 3:
                    dayName = "Jueves";
                    break;
                case 4:
                    dayName = "Viernes";
                    break;
                case 5:
                    dayName = "Sábado";
                    break;
                case 6:
                    dayName = "Domingo";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }
            return dayName;
        }

        static int getPow(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result *= baseNum;
            }

            return result;
        }
    }
}
