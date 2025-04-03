using System.Runtime.InteropServices;

public class Menu
{
    public void Start()
    {
        Console.Clear();
        string option = "4";

        ReflectionActivity reflectionActivity = new ReflectionActivity();
        ListingActivity listingActivity = new ListingActivity();
        do
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine();
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");

            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();

            if (option == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.DisplayStartingMessage();
                breathingActivity.Run();
            }
            else if (option == "2")
            {
                reflectionActivity.DisplayStartingMessage();
                reflectionActivity.Run();
            }
            else if (option == "3")
            {

                listingActivity.DisplayStartingMessage();
                listingActivity.Run();
            }
            else
                Console.WriteLine("Good bye!");

        } while (int.Parse(option) < 4);
    }
}