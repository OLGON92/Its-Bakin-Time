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
      else if(totalLoaves == 2)
      {
        return totalPrice = 10;
      }
      else 
      {
       int breadDeduction = (totalLoaves - (totalLoaves % 3)) /3 * BreadLoafCost;
       totalPrice = (totalLoaves * BreadLoafCost) - breadDeduction;
       return totalPrice;
      }
      
    }
  }
}