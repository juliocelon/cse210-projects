/*
Author: Julio Celón.

Showing Creativity and Exceeding Requirements
> I enhanced the project to ensure that no random prompts or questions are repeated in the current session,
  when all of them are used, the program inform to the user: "We have reach all available prompts/questions. Thanks!"
*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        Menu menu = new Menu();
        menu.Start();
    }
}