namespace Bakery.Models
{
  public class Bread
  {
    public int BreadLoafAmt {get; set;}
    public int BreadLoafCost {get; set;}

    public Bread(int breadLoafAmt)
    {
      BreadLoafAmt = breadLoafAmt;
      BreadLoafCost = 5;
    }

    public int GetBreadPrice()
    {
      int totalPrice = 0;
      int totalLoaves = BreadLoafAmt;
      if(totalLoaves == 1)
      {
        return totalPrice = 5;
      }
      else return 6;
    }
  }
}