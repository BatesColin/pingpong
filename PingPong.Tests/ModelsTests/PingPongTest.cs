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
      Assert.AreEqual(true, testPingPong.IsThisAPositiveNumber(234));
    }
    // [TestMethod]
    // public void UserInput_Test()
    // {
    //   PingPong testPingPong = new PingPong();
    //   Assert.AreEqual(40, testPingPong.UserInput("40"));
    // }
    //
    [TestMethod]
    public void ConvertToPingPong()
    {
      Assert.AreEqual("Ping-Pong", PingPong.ConvertToPingPong(30));
    }
    [TestMethod]
    public void ConvertToPingPong()
    {
      Assert.AreEqual("Ping", PingPong.ConvertToPingPong(9));
    }
    [TestMethod]
    public void ConvertToPingPong()
    {
      Assert.AreEqual("Pong", PingPong.ConvertToPingPong(10));
    }
    [TestMethod]
    public void ConvertToPingPong()
    {
      Assert.AreEqual("16", PingPong.ConvertToPingPong(16));
    }
  }
}
