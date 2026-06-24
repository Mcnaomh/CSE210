using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        float userNumber = PromptUserNumber();
        float squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string textNumber = Console.ReadLine();
        int userNumber = int.Parse(textNumber);
        return userNumber;
    }

    static float SquareNumber(float number)
    {
        float squaredNumber = number * number;
        return squaredNumber;
    }

    static void DisplayResult(string userName, float userNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {userNumber}");
    }
}