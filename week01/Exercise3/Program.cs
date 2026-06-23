using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        int numGuess = 0;
        
        while (numGuess != number)
        {   
            Console.Write("What is your guess? ");
            string answer = Console.ReadLine();
            numGuess = int.Parse(answer);     
            
            if (numGuess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (numGuess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                if (numGuess == number)
                {
                    Console.WriteLine("You guessed it!");
                } 
            }
        }   
    }
}