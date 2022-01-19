namespace SE1RoutingLib
{
    public abstract class LocationBase
    {
        public LocationBase(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double X { get; }
        public double Y { get; }
    }
}