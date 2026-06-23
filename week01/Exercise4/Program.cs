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
        
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string textnumber = Console.ReadLine();
            number = int.Parse(textnumber);
            numbers.Add(number);
        }
        Console.WriteLine(numbers);
    }
}