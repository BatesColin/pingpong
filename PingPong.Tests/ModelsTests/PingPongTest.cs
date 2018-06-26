using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongTest
  {
    [TestMethod]
    public void IsThisAPositiveNumber_Test()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual(true, testPingPong.IsThisANumber(234));
    }
    [TestMethod]
    public void ListNumbers_()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual(true, testPingPong.IsThisANumber(234));
    }
  }
}
