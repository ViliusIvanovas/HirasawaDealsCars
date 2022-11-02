/* public class Car 
{
  public string model;
  public string color;
  public int year;

   public Car(string cModel, string cColor, int cYear)
   {
      cModel = "Model";
      cColor = "Color";
      cYear = 2000;
   }
} */

public class Car 
{
  string model;
  string color = "red";
  int year = 2005;

   public Car(string a, string b, int c){
    model = a;
    color = b;
    year = c;
   }

  public void PrintCar()
  {
    Console.WriteLine(model);
    Console.WriteLine(color);
    Console.WriteLine(year);
  }
}