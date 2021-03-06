using System; // "import" System so that we can use the Console class
using System.Collections.Generic; // so we can use Lists
// using [namespace] directive imports the types contained in the given namespace, but does NOT import nested namespaces. This is to avoid naming conflicts and explains why we must import both System and System.Collections.Generic eventhough the latter namespace is nested in the former.
using Dealership.Models; // "using" is called a directive - it tells C# that the code in this file will be using code that isn't contained in this file or in this file's namespace.

namespace Dealership {
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

      yugo.SetPrice(300);

      // A Static method
      Console.WriteLine(Car.MakeSound("bang"));
      // Static methods are called by using the class name, NOT the instance of the class. A static method in C# is a method that keeps only one copy of the method at the Type level, not the object level. This means ALL instances of the class share the same copy of the method and its data. The LAST updated value of the method is shared among all objects of that Type.

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
        Console.WriteLine("----------------------");
        Console.WriteLine(automobile.GetMakeModel());
        Console.WriteLine(automobile.GetMiles() + " miles");
        Console.WriteLine("$" + automobile.GetPrice());
      }
    }
  }
}

