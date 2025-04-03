public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity")
    {
        string description = "This activity will help you relax by walking your " +
        "through breathing in and out slowly. Clear your mind and focus on your " +
        "breathing";
        base._description = description;
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(6);
            Console.WriteLine();
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}