using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryQuantity_GetsNumberOfPastry_true()
    {
      int numberOfPastry = 3;
      Pastry newPastryTest = new Pastry(numberOfPastry);
      Assert.AreEqual(typeof(Pastry), newPastryTest.GetType());
    }

    //[TestMethod]
    //public void getPastryTotalPrice_ReturnsTotalPastryPriceWithDisscount_int()
    //{
     //Pastry newPastryTest = new Pastry(3);
     //Assert.AreEqual(5,newPastryTest);
    //}
  }
}
  
  
    