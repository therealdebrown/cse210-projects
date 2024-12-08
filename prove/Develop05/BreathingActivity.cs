public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public override void Run()
    {
        DisplayStartingMessage();

        for (int i = 0; i < _duration / 6; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);
            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
        }

        DisplayEndingMessage();
    }
}
