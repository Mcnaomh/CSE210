using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        string gradeFromUser = Console.ReadLine();
        int numericGrade = int.Parse(gradeFromUser);
        string letter = "";

        if (numericGrade >= 90)
        {
            letter = "A";
        }
        else if (numericGrade >= 80)
        {
            letter = "B";
        }
        else if (numericGrade >= 70)
        {
            letter = "C";
        }
        else if (numericGrade >= 60)
        {
            letter = "D";
        }
        else
            letter = "F";
        
        Console.WriteLine($"Your grade is: {letter}");
        
        if (numericGrade >= 70)
        {
            Console.WriteLine("Congrats, you passed the course :D");
        }
        else
        {
            Console.WriteLine("You failed, get it together and keep pushing");
        }
    }   
}