public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing", "A calming breathing exercise.", 30) { }

    public override void Run()
    {
        DisplayStartingMessage();
        ShowCountdown(3);

        for (int i = 0; i < _duration / 6; i++)
        {
            Console.WriteLine("Breathe in......");
            ShowSpinner(3);
            Console.WriteLine("Hold......");
            ShowSpinner(3);
            Console.WriteLine("Breathe out......");
            ShowSpinner(3);
        }

        DisplayEndingMessage();
    }
}
