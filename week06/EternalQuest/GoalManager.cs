using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void Start()
    {
        int choice = 0;
        Console.Clear();
        do
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Delete Goal");
            Console.WriteLine("7. Quit");
            Console.WriteLine();
            Console.Write("Select a choise from menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                CreateGoal();
            }
            else if (choice == 2)
            {
                ListGoals();
            }
            else if (choice == 3)
            {
                SaveGoals();
            }
            else if (choice == 4)
            {
                LoadGoals();
            }
            else if (choice == 5)
            {
                RecordEvent();
            }
            else if (choice == 6)
            {
                DeleteGoal();
            }
            else
            {
                Console.WriteLine("Bye");
                choice = 6;
            }

        } while (choice != 7);
    }
    public void CreateGoal()
    {
        Console.WriteLine();
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine();
        Console.Write("Which type of goal would you like to create? ");
        int typeGoalChoice = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int goalpoints = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (typeGoalChoice == 1)
        {
            SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalpoints);
            _goals.Add(simpleGoal);
        }
        else if (typeGoalChoice == 2)
        {
            EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalpoints);
            _goals.Add(eternalGoal);
        }
        else if (typeGoalChoice == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalpoints, target, bonus);
            _goals.Add(checklistGoal);
        }

        Console.Write("Your goal has been created successfully!");
        Console.WriteLine();
    }
    public void ListGoals()
    {
        Console.WriteLine();
        Console.WriteLine("The goals are:");
        Console.WriteLine();

        int count = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetDetailsString()}");
            count++;
        }
        Console.WriteLine();
    }

    public void SaveGoals()
    {
        Console.WriteLine();
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{_score}");

            foreach (Goal goal in _goals)
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
        }

        Console.WriteLine();
        Console.Write("Your goals have been saved successfully!");
        Console.WriteLine();
    }

    public void LoadGoals()
    {
        Console.WriteLine();
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        _goals = new List<Goal>();
        int lineNumber = 0;
        foreach (string line in lines)
        {
            if (lineNumber == 0)
            {
                _score = int.Parse(line);
            }
            else
            {
                string[] parts = line.Split(":");

                string goalType = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                if (goalType == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(parts[4]);

                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    simpleGoal.SetIsComplete(isComplete);

                    _goals.Add(simpleGoal);
                }
                else if (goalType == "EternalGoal")
                {
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);

                    _goals.Add(eternalGoal);
                }
                else if (goalType == "ChecklistGoal")
                {
                    int bonus = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int amountCompleted = int.Parse(parts[6]);

                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                    checklistGoal.SetAmountCompleted(amountCompleted);

                    _goals.Add(checklistGoal);
                }
            }
            lineNumber++;
        }
        Console.WriteLine();
        Console.Write("Your goals have been loaded successfully!");
        Console.WriteLine();
    }
    public void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you accomplished? ");
        int goalId = int.Parse(Console.ReadLine());

        _goals[goalId - 1].RecordEvent();
        _score += _goals[goalId - 1].GetPoints();

        Console.WriteLine();
        Console.Write("Your goal has been recorded successfully!");
        Console.WriteLine();
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
    }

    public void DeleteGoal()
    {
        ListGoals();
        Console.Write("Which goal do you want to delete? ");
        int goalId = int.Parse(Console.ReadLine());

        _goals.RemoveAt(goalId - 1);

        Console.WriteLine();
        Console.Write("Your goal has been deleted successfully!");
        Console.WriteLine();
    }
}