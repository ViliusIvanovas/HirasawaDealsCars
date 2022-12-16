public class Player
{
    // This sets up all the variables to be used for this class
    public string? name;
    public int balance;
    public List<string> ownedCars = new List<string>();
    public List<string> carsAvailable = new List<string> { "2021 Porsche 911 GT3RS", "2017 Toyota Prius", "2014 Toyota AYGO", "2004 Kaku P-Model"};

    // This codes main purpose, is to enturprate the command we send from program.cs, 
    public Player(string? givenName, int givenBalance)
    {
        name = givenName;
        balance = givenBalance;
    }
    public static void makeOwner(Car car, Player user)
    {   
        string carName = car.year + " " + car.brand + " " + car.model;

        Console.WriteLine(carName);
        Console.ReadKey();

        user.carsAvailable.Contains(carName);

        int index = user.carsAvailable.FindIndex(x => x.StartsWith(carName));

        Console.WriteLine(index);
        Console.ReadKey();

        string carToAdd = user.carsAvailable[index];

        user.carsAvailable.RemoveAt(index);

        user.ownedCars.Add(carToAdd);
    }
}
