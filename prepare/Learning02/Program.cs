using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();

        job1._company = "Debrown Tech";
        job1._JobTitle = "Software Engineer";
        job1._startYear = 2020;
        job1._endYear = 2023;

        Job job2 = new Job();

        job2._company = "Debrown Tech";
        job2._JobTitle = "Owner and manager";
        job2._startYear = 2020;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Moise Fabrice";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}