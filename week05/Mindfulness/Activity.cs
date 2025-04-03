public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name)
    {
        _name = name;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(5);

        Console.WriteLine($"You have completed {_duration} seconds of {_name}");
        ShowSpinner(5);
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        int index = 0;
        while (DateTime.Now < futureTime)
        {
            Console.Write($"{animationString[index]}");
            Thread.Sleep(500);
            Console.Write("\b \b");

            index++;

            if (index >= animationString.Count)
                index = 0;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}