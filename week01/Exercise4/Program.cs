using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //Variables
        List<int> numbers = new List<int>();
        int number = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        //Loop to get the list of numbers
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string textnumber = Console.ReadLine();
            number = int.Parse(textnumber);
            if (number != 0)
            {
                numbers.Add(number);    
            }
            
        }
        //Sum of all the numbers in the list 
        int sumOfList = 0;
        foreach (int n in numbers)
        {
            sumOfList += n;
        }
        double average = numbers.Average();
        int max = numbers.Max();
        
        //Print statements
        Console.WriteLine($"The sum is: {sumOfList}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

    }   

}