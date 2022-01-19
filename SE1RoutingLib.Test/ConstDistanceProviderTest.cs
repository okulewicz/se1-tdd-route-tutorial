using Microsoft.VisualStudio.TestTools.UnitTesting;
using SE1RoutingLib.DistanceProviders;

namespace SE1RoutingLib.Test
{
    [TestClass]
    public class ConstDistanceProviderTest
    {

        [TestMethod]
        public void DistanceTest()
        {
            const int expectedDistance = 2;
            IDistanceCalculator distanceCalculator = new ConstantDistanceProvider(3);
            Location location1 = new Location(0.0, 0.0);
            Location location2 = new Location(1.0, 0.0);
            Assert.AreEqual(expectedDistance, distanceCalculator.GetDistance(location1, location2));
        }
    }
}
