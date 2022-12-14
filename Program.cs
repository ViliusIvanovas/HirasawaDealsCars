#region Methods
List<string> messages = new List<string>();
int delayTime = 0;
/*This method is used throughout the code for writing things in the console. 
This way, we won't have to repeat ourselves whenever we want to write a message.
By using messages.Add, we can define the messages we want to send. Once we're done, 
we simply call the Message function to write the messages.*/
void Message()
{
    Console.Clear();
    foreach (string Item in messages)
    {
        Console.WriteLine(Item);
        Thread.Sleep(delayTime);
    }
    Console.WriteLine("------------------------------\n");
    messages.Clear();
}

#endregion

#region Story

messages.Add("First off, select a game mode. This will determine the speed of the text.\na - Immersion: 1.5 seconds delay\nb - Speed: no delay");
Message();

ConsoleKey gameMode = Console.ReadKey().Key;
switch (gameMode)
{
    case ConsoleKey.A:
        {
            delayTime = 1500;
        }
        break;

    case ConsoleKey.B:
        {
            delayTime = 0;
        }
        break;

    default:
        break;
}

start:
Console.Title = "Parking Lot";
messages.Add("Finally, after what feels like two years of pilgrimage, you have arrived.");
messages.Add("The car shop stands before you: an imposing block of concrete, large display windows tracing its clean walls.");
messages.Add("Now, you need only walk in the door... (Press a key)");
Message();
Console.ReadKey();

#region Chevron Cars
Console.Clear();
Console.Title = "Chevron Cars";

messages.Add("Welcome to Chevron Cars!");
messages.Add("My name's John Chevron, and I *love* cars! I'm here to help you pick the best car for your needs!");
messages.Add("And what might your name be?");
Message();

string? userName = Console.ReadLine();

//                         name  riches
Player User = new Player(userName, 5000000);

//    name             brand         model    color   year locked  price
Car porsche = new Car("Porsche", "911 GT3RS", "Blue", 2021, true, 1000000);
Car prius = new Car("Toyota", "Prius", "Black", 2017, false, 120000);
Car aygo = new Car("Toyota", "AYGO", "Silver", 2014, false, 80000);
Car kaku = new Car("Kaku", "P-Model", "Metal", 2004, true, 2000000);

Player.makeCarList(User);

foreach (string i in User.carsAvailable)
{
    Console.WriteLine(i);
}

Console.ReadKey();

messages.Add("Nice to meet you, " + userName + "!");
messages.Add("We've got some of the finest cars on show in our model room! Would you like to see it?\n(Press W to accept, or D to decline)");
Message();

#endregion

//Choice: model room
ConsoleKey inputKey = Console.ReadKey().Key;
switch (inputKey)
{
    #region model room

    case ConsoleKey.W:
        {
            Console.Clear();
            Console.Title = "In a Model Room";

            messages.Add("And here we are, " + userName + ", the model room!");
            messages.Add("As you can see, we've got cars of all kinds. Which one would you like to hear more about?");
            //List of cars
            //Temporary: prototype stuff
            messages.Add(User.carsAvailable[0]);
            messages.Add(User.carsAvailable[1]);
            messages.Add(User.carsAvailable[2]);
            messages.Add(User.carsAvailable[3]);
            Message();

            ConsoleKey inputKey2 = Console.ReadKey().Key;
            switch (inputKey2)
            {
                case ConsoleKey.D1:
                    {
                        messages.Add("The Kaku P-Model\u2014an excellent choice, I must say! She was made in Malaysia, and that mighty engine of hers is above the competition!");
                        messages.Add("What in particular would you like to know about?");
                        break;
                    }
                default:
                    break;
            }
            Console.ReadLine();
        }
        break;
    #endregion

    #region rejection
    case ConsoleKey.D:
        {
            messages.Add("I do not understand. You went all the way in here, just to reject my benevolent offer?!");
            messages.Add("For this, you'll pay.");
            messages.Add("(His hand moves to his left pocket, and he pulls out his MIBURI laser gun.)");
            messages.Add("A \"pew\" is the last thing you hear before falling to the ground...");
            Message();
            Console.ReadKey();
        }
        break;
    #endregion

    default:
        break;
}

//Start new game
Console.Title = "Another Game";
messages.Add("This playthrough is over, but you can start another. Press a key to do so.");
Message();

Console.ReadKey();
goto start;
#endregion

