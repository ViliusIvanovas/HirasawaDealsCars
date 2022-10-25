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
Console.Clear();
foreach(string Item in messages){
    Console.WriteLine(Item);
    Thread.Sleep(1000);
}
Console.WriteLine("------------------------------\n");
messages.Clear();
//We might have to delete the following line if we want to do something different after a message has been written.

}

#endregion


#region Story
Console.Title = "Parking Lot";
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
messages.Add("My name's Mr. Johnson, and I'm here to help you pick the best car for your needs!");
messages.Add("And what might your name be?");
Message();

string userName = Console.ReadLine(); 

messages.Add("Nice to meet you, " + userName + "!");
messages.Add("We've got some of the finest cars on show in our model room! Would you like to see it?\n(Press W to accept, or D to decline)");
Message();

if (Console.ReadKey().Key == ConsoleKey.W)
{
    Console.Clear();
    Console.Title = "In a Model Room";

    messages.Add("And here we are, the model room!");
    Message();
}

if (Console.ReadKey().Key == ConsoleKey.D)
{
    messages.Add("I do not understand. You went all the way in here, just to reject my benevolent offer?!");
    messages.Add("For this, you'll pay.");
    messages.Add("(His hand moves to his left pocket, and he pulls out his MIBURI laser gun.");
    messages.Add("A \"pew\" is the last thing you hear before falling to the ground...");
    Message();
}

Console.ReadLine();
#endregion