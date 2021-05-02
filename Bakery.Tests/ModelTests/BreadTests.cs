using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadQuantity_GetsNumberOfBreads_true()
    {
      int numberOfBreads = 2;
      Bread newBread = new Bread(numberOfBreads);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void getBreadTotalPrice_ReturnsTotalBreadPriceWithDisscount_int()
    {
     Bread newBreadTest = new Bread(3);
     int result = newBreadTest.getBreadTotalPrice();
     Assert.AreEqual(10,result);
    }
  }
}