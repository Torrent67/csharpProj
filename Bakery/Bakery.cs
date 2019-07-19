namespace Bakery.Bread
{
  class Bread
  {
    private string _Loafs;
    private string _Sweets;
    private int _Prices;

    public Bread(string loafs, string sweets, int prices)
    {
      _Loafs = loafs;
      _Sweets = sweets;
      _Prices = prices;
    }

    public string GetLoafs()
    {
      return _Loafs;
    }

    public string GetSweets()
    {
      return _Sweets;
    }
    
    public int GetPrices()
    {
      return _Prices;
    }

    public bool Cost(int breadPrice)
    {
      return (_Prices < breadPrice);
    }
    
  }
}
