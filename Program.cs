namespace StarTrekCaptains;

class Program
{
    static void Main(string[] args)
    {
        List<Captain> captains = new List<Captain>();

        Captain sisko = new Captain("Benjamin", "Sisko", "Defiant");
        Captain archer = new Captain("Jonathan", "Archer");
        Captain janeway = new Captain("Kathryn", "Janeway", "Voyager");
        Captain picard = new Captain("Jean-Luc", "Picard");
        Captain kirk = new Captain("James", "Kirk");

        captains.Add(sisko);
        captains.Add(archer);
        captains.Add(janeway);
        captains.Add(picard);
        captains.Add(kirk);

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
            captain.Info();
        }
        Console.WriteLine("");
    }
}
