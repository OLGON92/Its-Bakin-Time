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
      int resultAmt = newBread.BreadLoafAmt;
      //Assert
      Assert.AreEqual(breadLoafAmt, resultAmt);
    }

    [TestMethod]

    public void GetBreadPrice_FigureOutPriceOf1Loaf_Int()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(5, newBread.GetBreadPrice());
    }

    [TestMethod]
    public void GetBreadPrice_FigureOutPriceOf2Loaf_Int()
    {
      Bread newBread = new Bread(2);
      Assert.AreEqual(10, newBread.GetBreadPrice());
    }

    [TestMethod]
    public void GetBreadPrice_FigureOutPriceOf3Loaf_Int()
    {
      Bread newBread = new Bread(3);
      Assert.AreEqual(10, newBread.GetBreadPrice());
    }

    [TestMethod]
    public void GetBreadPrice_FigureOutPriceOf4Loaf_Int()
    {
      Bread newBread = new Bread(4);
      Assert.AreEqual(15, newBread.GetBreadPrice());
    }
  } 
}