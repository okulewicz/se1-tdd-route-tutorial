namespace SE1RoutingLib
{
    public interface IDistanceCalculator
    {
        double GetDistance(Location fromLocation, Location toLocation);
    }
}