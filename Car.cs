public class Car
{
    // This sets up all the variables to be used for this class
    public string model;
    public string color;
    public int year;
    public bool locked;
    public int doors;

    // This codes main purpose, is to enturprate the command we send from program.cs, when we want a car, this code just makes it into a couple of variables, which we can later use for things
    public Car(string givenModel, string givenColor, int givenYear, bool givenLocked, int GivenDoors)
    {
        model = givenModel;
        color = givenColor;
        year = givenYear;
        locked = givenLocked;
        doors = GivenDoors;
    }

    // Setting up a script for doors or similar
    /*public doors(int doors)
    {
        
    }*/
}