/*

Showing Creativity and Exceeding Requirements

I added a new option to the menu that allows users to delete a goal.
Additionally, when displaying the list of goals, each goal now shows 
its associated point value. For checklist goals, the information is 
now customized to show the points and bonus if it is completed.

*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        GoalManager menu = new GoalManager();
        menu.Start();
    }
}