public class Transactions
{
    #region Fields

    #endregion

    #region Methods

    public static bool buyCar(Car car, Player payer)
    {
        if (payer.balance >= car.price)
        {
            payer.balance = payer.balance - car.price;

            Player.makeOwner(car, payer);

            return true;
        }
        else
        {
            return false;
        }
    }


    #endregion
}