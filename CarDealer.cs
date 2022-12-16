public class CarDealer
{
    #region Fields

    public static List<string> messages = new List<string>();

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
                break;
                CarDealer.messages.Add("Oops, haha, looks like the car is locked! Couldn't be my fault now, could it?");
                doors.open = false;
            default:
                break;
                CarDealer.messages.Add("I used to open people's doors for a living. Then I found my own door. And here I am!");
                doors.open = openState;
        }
    }
    public static void getSpecs(Car vehicle)
    {
        CarDealer.messages.Add("This car belongs to the brand" + vehicle.brand);
        CarDealer.messages.Add("The" + vehicle.model + "is an excellent choice!");
        CarDealer.messages.Add("The car is the color" + vehicle.color);
        CarDealer.messages.Add("This model was released in the year" + vehicle.year);
    }
    #endregion
}