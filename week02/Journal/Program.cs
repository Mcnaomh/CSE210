using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator prompts = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine();
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = prompts.GetRandomPrompt();

                Console.WriteLine();
                Console.WriteLine(prompt);
                Console.Write("> ");

                string answer = Console.ReadLine();

                Entry newEntry = new Entry();

                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText = answer;

                myJournal.AddEntry(newEntry);
            }
            else if (choice == 2)
            {
                myJournal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Filename: ");
                string fileName = Console.ReadLine();

                myJournal.SaveToFile(fileName);
            }
            else if (choice == 4)
            {
                Console.Write("Filename: ");
                string fileName = Console.ReadLine();

                myJournal.LoadFromFile(fileName);
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Please enter a valid option.");
            }
        }
    }
}