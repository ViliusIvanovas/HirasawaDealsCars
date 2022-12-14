public class Car
{
    // This sets up all the variables to be used for this class
    public string brand;
    public string model;
    public string color;
    public int year;
    public bool locked;
    public int price;
    public DoorsClass EngineBayDoor, DriverDoor, PassengerDoor, BackDriverDoor, PassengerBackDoor, HatchDoor;

    // This codes main purpose, is to enturprate the command we send from program.cs, 
    // when we want a car, this code just makes it into a couple of variables, which we can later use for things
    public Car(string givenBrand, string givenModel, string givenColor, int givenYear, bool givenLocked, int givenPrice)
    {
        brand = givenBrand;
        model = givenModel;
        color = givenColor;
        year = givenYear;
        locked = givenLocked;
        price = givenPrice;

        EngineBayDoor = new DoorsClass(false);
        DriverDoor = new DoorsClass(false);
        PassengerDoor = new DoorsClass(false);
        BackDriverDoor = new DoorsClass(false);
        PassengerBackDoor = new DoorsClass(false);
        HatchDoor = new DoorsClass(false);
    }
}