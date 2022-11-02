public class CarDealer
{
    #region Fields
    List<Car> AvailableCars;
    #endregion

    #region Constructors

    public CarDealer()
    {
        AvailableCars = new List<Car>();

        AvailableCars.Add(new Car("bmw", "black", 2005));
        AvailableCars.Add(new Car("audi", "black", 2005));
        AvailableCars.Add(new Car("aston", "black", 2005));
        AvailableCars.Add(new Car("dodge", "black", 2005));

    }
    #endregion

    #region Methods

    public void PrintCarsList()
    {
        Console.WriteLine("Oh boy this sure should be a list of cars, I wonder if my code will cooporate with me for once, this bitch sucks ass.");
        AvailableCars.ForEach(i=> Console.Write("{0}\n", i));
    }
    #endregion
}