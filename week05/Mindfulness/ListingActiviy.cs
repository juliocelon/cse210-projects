public class ListingActivity : Activity
{
    List<string> _prompts;
    public ListingActivity() : base("Listing Activity")
    {
        string description = "This activity will help you reflect on the " +
        "good things in your life by having you list as many things as you " +
        "can in a certain area.";
        base._description = description;
        InitializePrompts();
    }

    public void InitializePrompts()
    {
        _prompts = new List<string>();
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();

        if (_prompts.Count == 0)
            return "";

        int index = random.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        _prompts.RemoveAt(index);
        return randomPrompt;
    }

    public void Run()
    {
        Console.Clear();

        string randomPrompt = GetRandomPrompt();

        if (randomPrompt == "")
        {
            Console.WriteLine($"We have reached all available prompts. Thank you!");
        }
        else
        {
            Console.WriteLine("Get Ready...");
            ShowSpinner(5);
            Console.WriteLine();

            Console.WriteLine("List as many responses you can to the following prompt:");
            Console.WriteLine();
            Console.WriteLine($"--- {randomPrompt} ---");
            Console.WriteLine();
            Console.Write("You may begin in: ");
            ShowCountDown(9);
            Console.Clear();

            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(_duration);

            int count = 0;
            while (DateTime.Now < futureTime)
            {
                Console.Write(">");
                Console.ReadLine();
                count++;
            }

            Console.WriteLine();
            Console.WriteLine($"You listed {count} items!");

            DisplayEndingMessage();
        }
    }
}