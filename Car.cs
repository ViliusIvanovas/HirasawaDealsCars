public class Car
{
    string model;
    string color;
    int year;

    public void CarMaker(string model, string color, int year, bool locked)
    {
        string carModel = model;
        string carColor = color;
        int carYear = year;
        bool carLocked = locked;
    }

    public void PrintCar()
    {
        Console.WriteLine(model);
        Console.WriteLine(color);
        Console.WriteLine(year);
    }
}