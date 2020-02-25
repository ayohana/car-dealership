using System; // we need a System directive in order to allow our setter methods to "set" a private field on an existing object.

namespace Dealership.Models
{
  public class Car // declaration of a global class
  // public = an access level modifier determining this info can be accessed globally/publicly
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    // Naming private variables should be: _camelCase

    public Car(string makeModel, int price, int miles) // a constructor to "Car" class
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public int GetPrice()
    {
      return _price;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (_price < maxPrice);
    }

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }

    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }
  }
}