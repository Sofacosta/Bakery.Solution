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
  }
}