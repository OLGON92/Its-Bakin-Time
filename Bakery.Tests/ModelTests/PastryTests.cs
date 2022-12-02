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
    
    [TestMethod]

    public void GetPastryPrice_FigureOutPriceOf1Pastry_Int()
    {
      //Arrange
      int pastryAmt = 1;
      Pastry newPastry = new Pastry(pastryAmt);
      //Act
      int resultTotal = newPastry.GetPastryPrice();
      //Assert
      Assert.AreEqual(2, resultTotal);
    }

    [TestMethod]

    public void GetPastryPrice_FigureOutPriceOf2Pastry_Int()
    {
      //Arrange
      int pastryAmt = 2;
      Pastry newPastry = new Pastry(pastryAmt);
      //Act
      int resultTotal = newPastry.GetPastryPrice();
      //Assert
      Assert.AreEqual(4, resultTotal);
    }

    [TestMethod]

    public void GetPastryPrice_FigureOutPriceOf3Pastry_Int()
    {
      //Arrange
      int pastryAmt = 3;
      Pastry newPastry = new Pastry(pastryAmt);
      //Act
      int resultTotal = newPastry.GetPastryPrice();
      //Assert
      Assert.AreEqual(5, resultTotal);
    }

    [TestMethod]

    public void GetPastryPrice_FigureOutPriceOf4Pastry_Int()
    {
      //Arrange
      int pastryAmt = 4;
      Pastry newPastry = new Pastry(pastryAmt);
      //Act
      int resultTotal = newPastry.GetPastryPrice();
      //Assert
      Assert.AreEqual(7, resultTotal);
    }
  } 
}