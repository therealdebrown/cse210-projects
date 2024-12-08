using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> 
    {
        "Name things you are grateful for.",
        "List your favorite hobbies.",
        "Write down things that make you happy."
    };

    public ListingActivity() 
        : base("Listing", "An activity to list items and reflect.", 60) { }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    private List<string> GetListFromUser()
    {
        List<string> userResponses = new List<string>();
        Console.WriteLine("Start listing. Press Enter after each item. Type 'done' to finish:");
        while (true)
        {
            string response = Console.ReadLine();
            if (response.ToLower() == "done") break;
            userResponses.Add(response);
        }
        return userResponses;
    }

    public override void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        ShowCountdown(3);

        List<string> responses = GetListFromUser();
        Console.WriteLine($"You listed {responses.Count} items. Great job!");

        DisplayEndingMessage();
    }
}
