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

    //public int GetPastryPrice()
  }
}