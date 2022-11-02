public class CarDealer{
    #region Fields
    List<Car> AvailableCars;
    #endregion

    #region Constructors
    

    public CarDealer(){
        AvailableCars = new List<Car>();

        AvailableCars.Add(new Car("bmw","black",2005));
        AvailableCars.Add(new Car("audi","black",2005));
        AvailableCars.Add(new Car("aston","black",2005));
        AvailableCars.Add(new Car("dodge","black",2005));
        
    }
    #endregion

    #region Methods

    public void PrintAllCars(){
        foreach (Car item in AvailableCars)
        {
            item.PrintCar();
        }
    }
    #endregion
}