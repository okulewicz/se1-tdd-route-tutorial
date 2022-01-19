using Microsoft.VisualStudio.TestTools.UnitTesting;
using SE1RoutingLib.DistanceProviders;

namespace SE1RoutingLib.Test
{
    [TestClass]
    public class RouteTest
    {
        IDistanceCalculator distanceCalculator = new EuclideanDistanceCalculator();
        Location location1 = new Location(0.0, 0.0);
        Location location2 = new Location(1.0, 0.0);

        [TestMethod]
        public void EmptyRouteLengthTest()
        {
            double expectedLengthEmptyRoute = 0.0;
            Route emptyRoute = new Route(distanceCalculator);
            Assert.AreEqual(expectedLengthEmptyRoute, emptyRoute.Length);
        }

        [TestMethod]
        public void WaypointAdditionTest()
        {
            double expectedLengthRouteWithPoint = 0.0;
            Route routeWithPoint = new Route(distanceCalculator);
            routeWithPoint.Add(location1);
            Assert.AreEqual(expectedLengthRouteWithPoint, routeWithPoint.Length);
        }

        [TestMethod]
        public void WaypointsAdditionTest()
        {
            double expectedLengthRouteWithPoint = 1.0;
            Route routeWithTwoPoints = new Route(distanceCalculator);
            routeWithTwoPoints.Add(location1);
            routeWithTwoPoints.Add(location2);
            Assert.AreEqual(expectedLengthRouteWithPoint, routeWithTwoPoints.Length);
        }
    }
}
