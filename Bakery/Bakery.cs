using System;

namespace Bakery
{
  class Bread
  {
    private string _Bread;
    private int _Prices;

    public Bread(string bread, int prices)
    {
      _Bread = bread;
      _Prices = prices;
    }

    public string GetLoafs()
    {
      return _Bread;
    }


    public int GetPrices()
    {
      return _Prices;
    }

  }
}
