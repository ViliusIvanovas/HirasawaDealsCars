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


#region Methods

List<string> messages = new List<string>();

/*This method is used throughout the code for writing things in the console. 
This way, we won't have to repeat ourselves whenever we want to write a message.

By using messages.Add, we can define the messages we want to send. Once we're done, 
we simply call the Message function to write the messages.*/
void Message()
{
foreach(string Item in messages){
    Console.WriteLine(Item);
    Thread.Sleep(400);
}
Console.WriteLine("------------------------------\n");
messages.Clear();
//We might have to delete the following line if we want to do something different after a message has been written.

}

#endregion


#region Story
messages.Add("Finally, after what feels like two years of pilgrimage, you have arrived.");
messages.Add("The car shop stands before you: an imposing block of concrete, large display windows tracing its clean walls.");
messages.Add("Now, you need only walk in the door... (Press W)");
Message();
if (Console.ReadKey().Key == ConsoleKey.W)
{
    goto start;
}

start: 
Console.Clear();
Console.Title = "1984 Cars";

messages.Add("Welcome to 1984 Cars!");
messages.Add("2 2");
messages.Add("3 3");
Message();


Console.ReadLine();
#endregion