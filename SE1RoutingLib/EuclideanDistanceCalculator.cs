using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE1RoutingLib
{
    public class EuclideanDistanceCalculator : IDistanceCalculator
    {
        public double GetDistance(Location fromLocation, Location toLocation)
        {
            return Math.Sqrt((fromLocation.X - toLocation.X) * (fromLocation.X - toLocation.X)
                + (fromLocation.Y - toLocation.Y) * (fromLocation.Y - toLocation.Y));
        }
    }
}
