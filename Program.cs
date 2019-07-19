using System;
using System.Collections.Generic;
using Bakery.Shop;

namespace Bakery 
{

  public class Program
  {
    
    public static void Main()
    {

      Bread Loaf = new Bread(5);
      Bread Pastry = new Bread(2);
     

      List<Bread> Breads = new List<Bread>() { Loaf, Pastry };
      Console.WriteLine("Welcome to Pierre's Bakery! The French loaf specialist. We have a great deal this weekend! Buy 2 loaves of our bread get 1 free. A single loaf costs $5, OR our delcious Pasties are 1 for $2 or 3 for $5.");
      Console.WriteLine("____________________________________________________");
      Console.WriteLine("Due to our limited stock the maxium number of loaves you may buy are 6.");
      Console.WriteLine("____________________________________________________");
      Console.WriteLine("Enter what you would like to purchace[Loaf] or [Pastry]");
      string userInput = Console.ReadLine().ToLower();
      if (userInput == "loaf")
      {
       BreadCost();
      }
      else if (userInput == "pastry")
      {
        PastryCost();
      }
      
    }
      public static void BreadCost()
      {
       Console.WriteLine("Enter how many loaves you would like.");
        int userInt = int.Parse(Console.ReadLine());
        int checkoutLoaf = (userInt /2) + userInt;
        Console.WriteLine("Ammount of bread you're getting! " + checkoutLoaf + " And your total " + (userInt * 5) );
      }

      public static void PastryCost()
      {
        Console.WriteLine("Enter how many pastries you would like.");
        int userInt = int.Parse(Console.ReadLine());
        int checkoutPastry = (userInt /3);
        Console.WriteLine("Ammount of pastries you're getting! " + userInt + " And your total " + (userInt * 2 - checkoutPastry) );
      }

  }

}
  

