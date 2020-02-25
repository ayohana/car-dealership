namespace Dealership.Models
{
  public class Car // declaration of a global class
  // public = an access modifier determining this info can be accessed globally/publicly
  {
    public string MakeModel;
    public int Price;
    public int Miles;

    public Car(string makeModel, int price, int miles) // a constructor to "Car" class
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price < maxPrice);
    }
  }
}