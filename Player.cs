public class Player
{
    // This sets up all the variables to be used for this class
    public string? name;
    public int balance;
    public List<Car> ownedCars;
    public List<string> carsAvailable = new List<string> { "2021 Porsche 911 GT3RS", "2017 Toyota Prius", "2014 Toyota AYGO", "2004 Kaku P-Model"};

    // This codes main purpose, is to interpret the command we send from program.cs, 
    public Player(string? givenName, int givenBalance)
    {
        name = givenName;
        balance = givenBalance;
    }
    public static void RemoveCar(Car car, Player user)
    {
        string toRemove = car.year + " " + car.brand + " " + car.model;

        user.carsAvailable.Remove(toRemove);
    }

}