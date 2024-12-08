public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt peace this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() 
        : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many items as you can in a certain area.") { }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine($"Prompt: {GetRandomPrompt()}");
        ShowCountdown(3);

        Console.WriteLine("Start listing your responses. Type 'done' to finish early:");
        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string response = Console.ReadLine();
            if (response.ToLower() == "done") break; // Creative: Allows user to finish early
            count++;
        }

        Console.WriteLine($"You listed {count} items. Great work!");
        DisplayEndingMessage();
    }
}
