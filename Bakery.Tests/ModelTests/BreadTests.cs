using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BreadQuantity_GetsNumberOfBreads_int()
    {
      int numberOfBreads = 2;
      Bread newBread = new Bread(numberOfBreads);
      //Arrange

      //Act

      //Assert
    }
  }
}