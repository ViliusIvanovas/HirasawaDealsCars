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
    public static void makeCarList(Player player)
    {
        player.carsAvailable.Add("2021 Porsche 911 GT3RS");
        player.carsAvailable.Add("2017 Toyota Prius");
        player.carsAvailable.Add("2014 Toyota AYGO");
        player.carsAvailable.Add("2004 Kaku P-Model");
    }
    public void RemoveCar(Car car, Player user)
    {
        string toRemove = car.year + " " + car.brand + " " + car.model;

        user.carsAvailable.Remove(toRemove);
    }

}
