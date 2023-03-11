namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        public static void Thousand()
        {
            for (var i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Threes()
        {
            for (var i = 3; i < 1000; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static void Compare()
        {
            int num1;
            int num2;
            Console.WriteLine("Please give me an integer:");
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("That was not a number. I need a number. Please try again:");
            }
            Console.WriteLine("Thank you. Now, please give me a second integer:");
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("That was not a number. I need a number. Please try again:");
            }

            if (num1 == num2)
            {
                Console.WriteLine("Cool! Those numbers are the same!");
            }
            else
            {
                Console.WriteLine("Hmmm. Those are definitely two different numbers.");
            }
        }

        //Write a method to check whether a given number is even or odd

        public static void EvenOdd()
        {
            int number;
            Console.WriteLine("Hello again! Please give me a number:");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("That was not a number. I need a number. Please try again:");
            }

            if (number % 2 == 0)
            {
                Console.WriteLine($"Your number, {number} is an even number.");
            }
            else
            {
                Console.WriteLine($"Your number, {number} is an odd number.");
            }
        }

        //Write a method to check whether a given number is positive or negative

        public static void PosNeg()
        {
            int num;
            Console.WriteLine("Let's play yet another number game! Please give me one more number:");
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("That was not a number. I need a number. Please try again:");
            }

            if (num > 0)
            {
                Console.WriteLine($"Your number, {num} is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"Your number, {num} is negative.");
            }
            else
            {
                Console.WriteLine($"Your number must be 0, which is neither positive nor negative!");
            }

        }

        //Write a method to read the age of a candidate and determine whether they can vote.

        public static void CanVote()
        {
            int age;
            Console.WriteLine("Well, now let's play another game. This game is called CAN YOU VOTE?? So....please enter your age right here:");
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("That was not a number. I need a number. Please try again:");
            }

            if (age >= 18)
            {
                Console.WriteLine($"Horray! Since your age is {age} you can vote.");
            }
            else
            {
                Console.WriteLine($"Sorry, the age of {age} is just too young to vote.");
            }
        }

        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void CheckRange()
        {
            int scope;
            Console.WriteLine("Thank you so much for playing with me! Now, there are just two more games that I would like to try. Please give me a number, and I will tell you if it is on or between -10 and 10.");
            while (!int.TryParse(Console.ReadLine(), out scope))
            {
                Console.WriteLine("That was not a number. I need a number. Please try again:");
            }
            if (scope >= -10 && scope <= 10)
            {
                Console.WriteLine($"Yes! The number you gave me, {scope} is indeed on or between -10 and 10! ");
            }
            else
            {
                Console.WriteLine($"Sorry. The number you gave me, {scope} is not on or between -10 and 10.");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MultiplyTwelve()
        {
            int ints;
            Console.WriteLine("This has been so fun! And now, I will perform my amazing trick! You shall witness my great ability to display the multiplication table of any given integer! Please, for one final time, provide me with a number from 1 to 12:");
            while (!int.TryParse(Console.ReadLine(), out ints))
            {
                Console.WriteLine("That was not a number. I need a number. Please try again:");
            }
            if (ints > 0 && ints < 13)
            {
                for (int count = 0; count <= ints; count++)
                {
                    Console.WriteLine(ints * count);
                }
                Console.WriteLine("Thank you for playing fun math games with me!");
            }
            else
            {
                Console.WriteLine("Oh no! You just didn't pick a number between 1 and 12! Now I can't show you my trick. Maybe next time?");
            }
            Console.WriteLine("Goodbye!");
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {

            //counting from 1000 to -1000
            Thousand();

            //counting by 3s from 3 to 999
            Threes();

            //checking to see if the numbers are the same or different

            Compare();

            //Method to see if the numbers are even or odd

            EvenOdd();

            //Method to see if the numbers are positive or negative
            PosNeg();

            //Method to see if the user can vote based on their age
            CanVote();

            //Method to see if the user provides a number between -10 and 10
            CheckRange();

            //Method to display the multiplication table of a given integer
            MultiplyTwelve();
         }
       }
    }



