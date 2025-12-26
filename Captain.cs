namespace StarTrekCaptains;

public class Captain
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string ShipName { get; private set; }
    
    public string Title => $"Captain {FirstName} {LastName}";


    public Captain(string firstName, string lastName, string shipName="Enterprise")
    {
        FirstName = firstName;
        LastName = lastName;
        ShipName = shipName;
    }

    public override string ToString() => $"{Title} is the captain of the USS {ShipName}";   
}