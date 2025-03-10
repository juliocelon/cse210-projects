using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project. Week 02");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2024;
        job1._endYear = 2025;

        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2025;
        job2._endYear = 2026;

        job2.Display();

        Resume resume = new Resume();
        resume._personName = "Allison Rose";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();

    }
}