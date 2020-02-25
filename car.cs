using System;
using System.Collections.Generic;

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

public class Program
{
  public static void Main()
  {
    Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
    Car yugo = new Car("1980 Yugo Koral", 700, 56000);
    Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
    Car amc = new Car("1976 AMC Pacer", 400, 198000);

    // A List of Car instances
    List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach(Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice))
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.MakeModel);
    }
  }
}