using System;
using System.Collections.Generic;
using Bread.Main;

namespace Bakery
{ 
   public class Program
  {
    public static void Main()
    {
      Loafs french = new Loafs("French Bread", 5);
      Loafs faguette = new Loafs("Baguette", 4);
      Loafs rye = new Loafs("Rye Bread", 6);
      Loafs wholeWheat = new Loafs("Whole Wheat", 4);

      List<Loafs> Loafss = new List<Loafs>() { french, baguette, rye, wholeWheat };

   
  }

}