namespace Bakery.Models
{
  public class Bread
  {
    public int BreadLoafCost {get; set;}
    public int BreadLoafAmt {get; set;}

    public Bread(int breadLoafAmt)
    {
      BreadLoafAmt = breadLoafAmt;
      BreadLoafCost = 5;
    }
  }
}