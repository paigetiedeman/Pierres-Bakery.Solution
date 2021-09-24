using System;
using PierresBakery.Models;

namespace BakeryOrder
{
  public class Program 
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("---------------------------");
      Console.WriteLine("Would you like to order Bread or Pastries?");
      userOrder();
    }
    public static void userOrder()
    {
      string choice = Console.ReadLine().ToLower();
      if (choice == "bread")
      {
        Console.WriteLine("Our promotion today is Buy 2 get the 1 free! Loaves regularly cost $5 each");
        Console.WriteLine("How many would you like?");
        string breadNumber = Console.ReadLine();
        int breadOrder = int.Parse(breadNumber);
        Bread newBread = new Bread(breadOrder);
        Console.WriteLine($"That will be ${newBread.BreadOrder()}");
        Main();
      }
      else if (choice == "pastries" || choice == "pastry")
      {
        Console.WriteLine("Our promotion today is Buy 1 for $2 or 3 for $5!");
        Console.WriteLine("How many would you like?");
        string pastryNumber = Console.ReadLine();
        int pastryOrder = int.Parse(pastryNumber);
        Pastry newPastry = new Pastry(pastryOrder);
        Console.WriteLine($"That will be ${newPastry.PastryOrder()}");
        Main();
      }
      else 
      {
        Console.WriteLine("That is not a valid input please enter either 'bread' or 'pastries'!");
        Main();
      }
    }
  }
}