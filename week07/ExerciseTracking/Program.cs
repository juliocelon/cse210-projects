using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        Console.WriteLine();

        Running runningActivity = new Running("14 Apr 2025", 30, 3);
        Cycling cyclingActivity = new Cycling("15 Apr 2025", 20, 30);
        Swimming swimmingActivity = new Swimming("16 Apr 2025", 45, 6);

        List<Activity> activities = new List<Activity>();
        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}