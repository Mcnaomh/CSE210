using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        job1._jobTitle = "Technical Support Engineer";
        job1._company = "Kaiser Permanente";
        job1._startYear = "2023";
        job1._endYear = "Current";

        Job job2 = new Job();
        job2._jobTitle = "Software Developer";
        job2._company = "BYU";
        job2._startYear = "2025";
        job2._endYear = "Current";

        Resume resume1 = new Resume();
        resume1._name = "Walter Jens Sanchez Fernandez";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        
        resume1.Display();
    }
}