using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]

    public void GetQty_ReturnPastryAmt_Int()
    {
      //Arrange
      int pastryAmt = 3;
      Pastry newPastry = new Pastry(pastryAmt);
      //Act
      int resultAmt = newPastry.PastryAmt;
      //Assert
      Assert.AreEqual(pastryAmt, resultAmt);
    }
    
  } 
}