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
      int pastryTotal = 2;
      Pastry newPastry = new Pastry(pastryAmt);
      //Act
      int resultTotal = newPastry.GetPastryPrice();
      //Assert
      Assert.AreEqual(pastryTotal, resultTotal);
    }

    [TestMethod]

    public void GetPastryPrice_FigureOutPriceOf2Pastry_Int()
    {
      //Arrange
      int pastryAmt = 2;
      int pastryTotal = 4;
      Pastry newPastry = new Pastry(pastryAmt);
      //Act
      int resultTotal = newPastry.GetPastryPrice();
      //Assert
      Assert.AreEqual(pastryTotal, resultTotal);
    }

    [TestMethod]

    public void GetPastryPrice_FigureOutPriceOf3Pastry_Int()
    {
      //Arrange
      int pastryAmt = 3;
      int pastryTotal = 5;
      Pastry newPastry = new Pastry(pastryAmt);
      //Act
      int resultTotal = newPastry.GetPastryPrice();
      //Assert
      Assert.AreEqual(pastryTotal, resultTotal);
    }

    [TestMethod]

    public void GetPastryPrice_FigureOutPriceOf4Pastry_Int()
    {
      //Arrange
      int pastryAmt = 4;
      int pastryTotal = 7;
      Pastry newPastry = new Pastry(pastryAmt);
      //Act
      int resultTotal = newPastry.GetPastryPrice();
      //Assert
      Assert.AreEqual(pastryTotal, resultTotal);
    }

    [TestMethod]

    public void GetPastryPrice_FigureOutPriceOf5Pastry_Int()
    {
      //Arrange
      int pastryAmt = 5;
      int pastryTotal = 9;
      Pastry newPastry = new Pastry(pastryAmt);
      //Act
      int resultTotal = newPastry.GetPastryPrice();
      //Assert
      Assert.AreEqual(pastryTotal, resultTotal);
    }

    [TestMethod]

    public void GetPastryPrice_FigureOutPriceOf6Pastry_Int()
    {
      //Arrange
      int pastryAmt = 6;
      int pastryTotal = 10;
      Pastry newPastry = new Pastry(pastryAmt);
      //Act
      int resultTotal = newPastry.GetPastryPrice();
      //Assert
      Assert.AreEqual(pastryTotal, resultTotal);
    }
  } 
}