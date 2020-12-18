using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey there, welcome to my guessing game");

            // make a random number between 0-100
            var RandomNum = new Random().Next(101);
            Console.WriteLine(RandomNum);
            var guess = -1;

            while(guess != RandomNum)
            {
                Console.WriteLine("Take a guess at what I am thinking, a number between 1-100.");

                var input = Console.ReadLine();
            

            if(int.TryParse(input, out guess))
            {
                if(guess == RandomNum)
                {
                    Console.WriteLine($"Woah you are a mind reader. I was thinking {RandomNum}.");
                    break;
                }
                else 
                {
                    Console.WriteLine($"Not quite. I think you should guess {(guess > RandomNum? "lower." : "higher.")}");
                }
                }
                
            }
            //Run after loop
            Console.WriteLine("Thanks for playing");
           
        }
    }
}
