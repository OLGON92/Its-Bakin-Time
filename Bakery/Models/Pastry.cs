namespace Bakery.Models
{
  public class Pastry{
    public int PastryAmt {get; set;}
    public int PastryCost {get; set;}

    public Pastry(int pastryAmt)
    {
      PastryAmt = pastryAmt;
      PastryCost = 2;
    }

    public int GetPastryPrice()
    {
      int totalPrice = 0;
      int pastryTotal = PastryAmt;

      if(pastryTotal <= 2)
      {
        totalPrice = (pastryTotal * PastryCost);
        return totalPrice;
      }
      else if(pastryTotal >= 3 && pastryTotal <= 5)
      {
        totalPrice = ((pastryTotal * PastryCost) - 1);
        return totalPrice;
      }
      else
      {
        totalPrice = ((pastryTotal * PastryCost) - 2);
        return totalPrice;
      }

    }
  }
}