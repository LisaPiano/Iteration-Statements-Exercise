namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
       

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        
        //Write a method to check whether a given number is even or odd
        
        //Write a method to check whether a given number is positive or negative
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
         
            //counting from 1000 to -1000
            for (var i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

            //counting by 3s from 3 to 999
            for (var i = 3; i < 1000; i += 3)
            { 
                Console.WriteLine(i);
            }

            //checking to see if the numbers are the same or different

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

            //Method to see if the numbers are even or odd

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

            //Method to see if the numbers are positive or negative
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


            //Method to see if the user can vote based on their age

            int age;
            Console.WriteLine("Well, now let's play another game. This game is called CAN YOU VOTE?? So....please enter your age right here:");
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("That was not a number. I need a number. Please try again:");
            }

            if (age >= 18) 
            { 
            Console.WriteLine($"Well, since your age is {age} you can vote.");
            }
            else
            {
                Console.WriteLine($"Sorry, the age of {age} is just too young to vote.");
            }

        }


    }
}

