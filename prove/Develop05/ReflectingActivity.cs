using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _questions = new List<string>
    {
        "What made you smile today?",
        "What is one thing you learned recently?",
        "How have you helped someone recently?"
    };

    public ReflectingActivity() 
        : base("Reflecting", "A reflective activity to think about your experiences.", 60) { }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(_questions.Count)];
    }

    public override void Run()
    {
        DisplayStartingMessage();
        string question = GetRandomQuestion();
        Console.WriteLine($"Question: {question}");
        ShowCountdown(3);

        Console.WriteLine("Take a moment to reflect...");
        ShowSpinner(_duration);

        DisplayEndingMessage();
    }
}
