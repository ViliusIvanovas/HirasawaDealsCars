public class CarDealer
{
    #region Fields
    // public List<Car> AvailableCars;

    #endregion

    #region Methods

    public static void unlockCar(Car car, bool lockState)
    {
        car.locked = lockState;
    }
    public static void openDoor(DoorsClass doors, bool openState, Car car)
    {
    switch (car.locked)
    {
        case false:
        doors.open = openState;
        break;
        default:
        doors.open = false;
        break;
    }
    }
    #endregion
}