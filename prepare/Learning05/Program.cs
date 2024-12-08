using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Moise Fabrice", "Differentiation");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Evans Ngolle", "Algebra",  "1.5",  "1-8");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Eric Bailey", "African Geography", "The lanscape of the Congo basin");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}