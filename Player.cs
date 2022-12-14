public class Player
{
    // This sets up all the variables to be used for this class
    public string? name;
    public int balance;
    public List<Car> ownedCars;
    public List<string> carsAvailable;

    // This codes main purpose, is to enturprate the command we send from program.cs, 
    public Player(string? givenName, int givenBalance)
    {
        name = givenName;
        balance = givenBalance;
    }
    
}