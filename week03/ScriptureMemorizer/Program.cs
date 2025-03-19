/*
Author: Julio Cesar Celon Altamirano

Showing Creativity and Exceeding Requirements
1. When selecting the random words to hide, the program hide only those words that are not already hidden.
2. I added a scripture library, this library is a List of Scriptures. The program then randomly selects one for the user to memorize.
*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Manager manager = new Manager();
        manager.Start();
    }
}