# region AllOurMethods

// Message();
// (Nothing to add)

//           Car    locked (True = locked)
// CarDealer.unlockCar(Car, LockState);

//                  Door to open  true = open  Car
// CarDealer.openDoor(DoorsClass, openState, Car);

//                    Car
// CarDealer.getSpecs(Car);

// Player.MakeOwner(Car, Player);
//                     Car  Player

//                  Car  Player
// Transactions.buyCar(Car, Player);

# endregion

# region Constructors

//     Name           Brand  Model  Color  Year  Locked  Price
// Car Car1 = new Car(Brand, Model, Color, Year, Lcoked, Price);

//            Name                   Yes = Open
// DoorsClass door1 = new DoorsClass(openState);
# endregion


#region Methods
int delayTime = 0;
/*This method is used throughout the code for writing things in the console. 
This way, we won't have to repeat ourselves whenever we want to write a message.
By using CarDealer.messages.Add, we can define the CarDealer.messages we want to send. Once we're done, 
we simply call the Message function to write the CarDealer.messages.*/
void Message()
{
    Console.Clear();
    foreach (string Item in CarDealer.messages)
    {
        Console.WriteLine(Item);
        Thread.Sleep(delayTime);
    }
    Console.WriteLine("------------------------------\n");
    CarDealer.messages.Clear();
}

#endregion

#region Story

CarDealer.messages.Add("First off, select a game mode. This will determine the speed of the text.\na - Immersion: 1.5 seconds delay\nb - Speed: no delay");
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
CarDealer.messages.Add("Finally, after what feels like two years of pilgrimage, you have arrived.");
CarDealer.messages.Add("The car shop stands before you: an imposing block of concrete, large display windows tracing its clean walls.");
CarDealer.messages.Add("Now, you need only walk in the door... (Press a key)");
Message();
Console.ReadKey();

#region Chevron Cars
Console.Clear();
Console.Title = "Chevron Cars";

CarDealer.messages.Add("Welcome to Chevron Cars!");
CarDealer.messages.Add("My name's John Chevron, and I *love* cars! I'm here to help you pick the best car for your needs!");
CarDealer.messages.Add("And what might your name be?");
Message();

string? userName = Console.ReadLine();

//                         name     riches
Player User = new Player(userName, 5000000);

//    name             brand         model    color   year  locked  price
Car porsche = new Car("Porsche", "911 GT3RS", "Blue", 2021, true, 1000000);
Car prius = new Car("Toyota", "Prius", "Black", 2017, false, 120000);
Car aygo = new Car("Toyota", "AYGO", "Silver", 2014, false, 80000);
Car kaku = new Car("Kaku", "P-Model", "Metal", 2004, true, 2000000);


CarDealer.messages.Add("Nice to meet you, " + userName + "!");
CarDealer.messages.Add("We've got some of the finest cars on show in our model room! Would you like to see it?\n(Press W to accept, or D to decline)");
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

            CarDealer.messages.Add("And here we are, " + userName + ", the model room!");
            CarDealer.messages.Add("As you can see, we've got cars of all kinds. Which one would you like to hear more about?");
            //List of cars
            //Temporary: prototype stuff
            CarDealer.messages.Add(User.carsAvailable[0]);
            CarDealer.messages.Add(User.carsAvailable[1]);
            CarDealer.messages.Add(User.carsAvailable[2]);
            CarDealer.messages.Add(User.carsAvailable[3]);
            Message();

            ConsoleKey inputKey2 = Console.ReadKey().Key;
            {
            switch (inputKey2)
                case ConsoleKey.D1:
                    {
                        CarDealer.messages.Add("The Kaku P-Model\u2014an excellent choice, I must say! She was made in Malaysia, and that mighty engine of hers is above the competition!");
                        CarDealer.messages.Add("What in particular would you like to know about?");
                        break;
                    }
                default:
                    break;
            }
            Console.ReadLine();
    ConsoleKey inputKey2 = Console.ReadKey().Key;
    switch (inputKey2)
    {
        case ConsoleKey.D1:
        {
        CarDealer.messages.Add("The Kaku P-Model\u2014an excellent choice, I must say! She was made in Malaysia, and that mighty engine of hers is above the competition!");
        CarDealer.messages.Add("1.Brand");
        CarDealer.messages.Add("What in particular would you like to know about?");
        CarDealer.messages.Add("2. Model");
        CarDealer.messages.Add("3. Color");
        CarDealer.messages.Add("4. Year");
        CarDealer.messages.Add("5. Unlock car");
        CarDealer.messages.Add("6. Buy (" + kaku.price +")" );    
        Message();

//1: This car belongs to the brand [brand].
//2: The [model] is an excellent choice! 
//3: The car is the color [color].
//4: This model was released in the year [year].
//5: (You hear a click) And there we go, I've unlocked the car for you! / (You once again hear a click) And now it's locked again!
//6: (Chevron hands you a key.) You're now the proud owner of a [brand + model]! Now, go for a ride and show the world what you were made for!
        break;

        }

        case ConsoleKey.D2:
        {
        
        break;
        }

        default:
        break;
    #endregion

    #region rejection
    case ConsoleKey.D:
        {
            CarDealer.messages.Add("I do not understand. You went all the way in here, just to reject my benevolent offer?!");
            CarDealer.messages.Add("For this, you'll pay.");
            CarDealer.messages.Add("(His hand moves to his left pocket, and he pulls out his MIBURI laser gun.)");
            CarDealer.messages.Add("A \"pew\" is the last thing you hear before falling to the ground...");
            Message();
            Console.ReadKey();
        }
        break;
    {
    CarDealer.messages.Add("I do not understand. You went all the way in here, just to reject my benevolent offer?!");
    CarDealer.messages.Add("You're tearing me apart, " + userName + "!");
    CarDealer.messages.Add("(His hand moves to his left pocket, and he pulls out his MIBURI laser gun.)");
    CarDealer.messages.Add("A \"pew\" is the last thing you hear before falling to the ground...");
    Message();
    Console.ReadKey();
    Thread.Sleep(5000);
    Console.Title = "£}031s";
    CarDealer.messages.Add("You wake up in a strange world... \n \n");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    CarDealer.messages.Add("- People are very strange these days. I used to know a girl, she had a dozen guys. One of them found out about it, beat her so bad that she ended up in a hospital on Guerrero Street.");
    CarDealer.messages.Add("- Hahaha, what a story, Mark!");
    Message();
    Console.ReadKey();
    break;
    }
    #endregion

    default:
        break;
}

//Start new game
Console.ForegroundColor = ConsoleColor.White;
Console.Title = "Another Game";
CarDealer.messages.Add("This playthrough is over, but you can start another. Press a key to do so.");
Message();

Console.ReadKey();
goto start;
#endregion

