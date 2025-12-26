namespace StarTrekCaptains;

class Program
{
    static void Main(string[] args)
    {
        List<Captain> captains = new List<Captain>() {
            new Captain("Benjamin", "Sisko", "Defiant"),
            new Captain("Jonathan", "Archer"),
            new Captain("Kathryn", "Janeway", "Voyager"),
            new Captain("Jean-Luc", "Picard"),
            new Captain("James", "Kirk")
        };

        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("===================");
            Console.WriteLine("=  Trek Captains  =");
            Console.WriteLine("===================");
            Console.WriteLine("[1] Display Captains");
            Console.WriteLine("[2] Quit");

            Console.Write("\nEnter your choice: ");
            string? userInput = Console.ReadLine();
            Console.WriteLine("");
            int choice = ValidateInput(userInput);
            
            switch (choice)
            {
                case 1:
                    DisplayAllStarTrekCaptains(captains);
                    break;

                case 2:
                    Console.WriteLine("Quitting...");
                    isRunning = false;
                    break;

                default:
                    Console.WriteLine("Invalid Option.");
                    break;
            }
        }
    }

    static int ValidateInput(string? userInput)
    {
        try
        {
            if (userInput == null)
            {
                throw new Exception("Input cannot be a null value.\n");
            }
            return int.Parse(userInput);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"\n{ex.Message}\n");
            return -1;
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"\n{ex.Message}\n");
            return -1;
        }
    }

    static void DisplayAllStarTrekCaptains(List<Captain> captainList)
    {
        foreach (Captain captain in captainList)
        {
            Console.WriteLine(captain);
        }
        Console.WriteLine("");
    }
}
