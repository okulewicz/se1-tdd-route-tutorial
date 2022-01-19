namespace SE1RoutingLib.DistanceProviders
{
    public class ConstantDistanceProvider : IDistanceCalculator
    {
        private int _expectedDistance;

        public ConstantDistanceProvider(int expectedDistance)
        {
            _expectedDistance = expectedDistance;
        }

        public double GetDistance(Location fromLocation, Location toLocation)
        {
            return _expectedDistance;
        }
    }
}