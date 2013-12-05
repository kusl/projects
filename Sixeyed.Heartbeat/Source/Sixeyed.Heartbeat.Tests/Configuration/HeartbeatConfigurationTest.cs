using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sixeyed.Heartbeat.Configuration;

namespace Sixeyed.Heartbeat.Tests
{
    /// <summary>
    /// Summary description for HeartbeatConfigurationTest
    /// </summary>
    [TestClass]
    public class HeartbeatConfigurationTest
    {
        [TestMethod]
        public void TestPopulated()
        {
            Assert.IsNotNull(HeartbeatConfiguration.Current);
        }
    }
}
