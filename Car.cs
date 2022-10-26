public class Car 
{
  string model;
  string color;
  int year;


public class beepBeep
{
   private string model;
   private string color;
   private int year;

   public beepBeep(string carModel, string carColor, int carYear)
   {
      carModel = "Kaku P-Model";
      carColor = "silver";
      carYear = 2004;
   }

   // Remaining implementation of Person class.
}
 /*
    Car Prius = new Car();
    Prius.model = "Toyota Prius";
    Prius.color = "black";
    Prius.year = 2018;

    Car Kaku = new Car();
    Kaku.model = "Kaku P-Model";
    Kaku.color = "silver";
    Kaku.year = 2004;

    Car Aygo = new Car();
    Aygo.model = "Toyota AYGO";
    Aygo.color = "gray";
    Aygo.year = 2014;

    Car Porsche = new Car();
    Porsche.model = "Porsche 911 GT3RS";
    Porsche.color = "tahoe blue metallic";
    Porsche.year = 2022;
*/
    public void printModel(){
        Console.WriteLine(model);

    }
  
}