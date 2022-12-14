public class Transactions
{
    #region Fields

    #endregion

    #region Methods

    public static bool buyCar(Car car, Player payer)
    {
        bool success;

        if (payer.balance > car.price)
        {
            payer.balance = payer.balance - car.price;
            Console.WriteLine(car.price + " Deducted from your balance");
            Console.WriteLine(payer.balance + " Is all you have left");

            payer.ownedCars.Add(car);

            success = true;
        }
        else
        {
            Console.WriteLine("Fail");
            success = false;
        }

        return success;
    }

    #endregion
}
