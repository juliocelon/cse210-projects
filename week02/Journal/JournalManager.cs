using System.Threading.Tasks.Dataflow;

public class JournalManager
{
    PromptGenerator _promptGenerator;
    Journal _journal;

    public JournalManager()
    {
        _promptGenerator = new PromptGenerator();
        _journal = new Journal();
    }
    public void Start()
    {
        int option = 0;
        Console.WriteLine("\nWelcome to the Journal Program!");
        do
        {
            Console.WriteLine("\nPlease, select one of the following choices:");
            Console.WriteLine("1. Write with a prompt");
            Console.WriteLine("2. Write with a title");
            Console.WriteLine("3. Display");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Save");
            Console.WriteLine("6. Quit");
            Console.Write("\nWhat would you like to do?: ");
            option = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (option == 1)
                Write(true);
            else if (option == 2)
                Write(false);
            else if (option == 3)
                Display();
            else if (option == 4)
                Load();
            else if (option == 5)
                Save();

        } while (option != 6);

    }

    public void Write(bool withPrompt)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        string timeText = theCurrentTime.ToString("HH:mm:ss");

        string promptOrTitle = "";
        if(withPrompt)
        {
            promptOrTitle = _promptGenerator.GetRandomPrompt();
            Console.WriteLine(promptOrTitle);
        }
        else
        {
            Console.Write("Title of your entry: ");
            promptOrTitle = Console.ReadLine();
        }

        System.Console.WriteLine("Your entry:");
        Console.Write("> ");

        string entryText = Console.ReadLine();

        Entry entry = new Entry();
        entry._date = dateText;
        entry._time = timeText;
        entry._promptOrTitleText = promptOrTitle;
        entry._entryText = entryText;

        if(withPrompt)
            entry._entryType = "prompt";
        else
            entry._entryType = "title";

        _journal.AddEntry(entry);
    }

    public void Display()
    {
        _journal.Display();
    }

    public void Load()
    {
        Console.Write("\nWhat is the filename?: ");
        string filename = Console.ReadLine();

        _journal.LoadFromFile(filename);
    }

    public void Save()
    {
        Console.Write("\nWhat is the filename?: ");
        string filename = Console.ReadLine();

        _journal.SaveToFile(filename);
    }
}