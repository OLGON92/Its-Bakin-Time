using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]

    public void GetQty_ReturnBreadLoafAmt_Int()
    {
      //Arrange
      int breadLoafAmt = 4;
      Bread newBread = new Bread(breadLoafAmt);
      //Act
      int resultAmt = newBread.BreadTotalAmt;
      //Assert
      Assert.AreEqual(breadLoafAmt, resultAmt);
    }
  } 
}