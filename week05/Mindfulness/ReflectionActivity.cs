public class ReflectionActivity : Activity
{
    List<string> _prompts;
    List<string> _questions;

    List<int> _promptTrack;
    public ReflectionActivity() : base("Reflection Activity")
    {
        string description = "This activity will help you reflect on times in " +
        "your life when you have shown strength and resilience. " +
        "This will help you recognize the power you have and how you can use it " +
        "in other aspects of your life.";
        base._description = description;

        InitializePrompts();
        InitializeQuestions();

    }

    public void InitializeQuestions()
    {
        _questions = new List<string>();
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        /*
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
        */
    }

    public void InitializePrompts()
    {
        _prompts = new List<string>();
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
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

    public string GetRandomQuestion()
    {
        Random random = new Random();

        if (_questions.Count == 0)
            return "";

        int index = random.Next(_questions.Count);
        string randomQuestion = _questions[index];
        _questions.RemoveAt(index);
        return randomQuestion;
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

            Console.WriteLine("Considere the following prompt:");
            Console.WriteLine();

            Console.WriteLine($"--- {randomPrompt} ---");
            Console.WriteLine();
            Console.WriteLine("When you have something in  mind, press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
            Console.Write("You may begin in: ");
            ShowCountDown(9);
            Console.Clear();

            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(_duration);

            while (DateTime.Now < futureTime)
            {
                string randomQuestion = GetRandomQuestion();
                if (randomQuestion == "")
                {
                    Console.WriteLine($"We have reach all available questions. Thanks!");
                    break;
                }

                Console.WriteLine($"> {randomQuestion}");
                ShowSpinner(10);
                
            }

            DisplayEndingMessage();
            InitializeQuestions();
        }

    }
}