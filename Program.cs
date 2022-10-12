#region Classes
/*
Car myFirstCar = new Car("Porsche");
Car myFirstCar_2 = new Car("BMW");
myFirstCar.Drive();

Car[] carArr = new Car[5];

List<Car> cars = new List<Car>();
cars.Add(new Car("Mercedes"));

*/
#endregion


#region Story

/*This method is used throughout the code for writing things in the console. 
This way, we won't have to repeat ourselves whenever we want to write a message.*/
void Message(string text)
{
Console.WriteLine(text);
Thread.Sleep(1000);
}

Message("Hello");
Message("Hello");
Message("Hello");
Console.ReadLine();
#endregion