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
      Pastry newPastry = new Pastry(numberOfPastry);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
  }
}
  
  
    