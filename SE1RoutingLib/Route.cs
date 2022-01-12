using System;
using System.Collections.Generic;
using System.Linq;

namespace SE1RoutingLib
{
    public class Route
    {
        private List<Location> _locations;
        private IDistanceCalculator _distanceCalculator;

        public double Length { get; private set; }

        public Route(IDistanceCalculator distanceCalculator)
        {
            _locations = new List<Location>();
            _distanceCalculator = distanceCalculator;
            Length = 0.0;
        }

        public void Add(Location location)
        {
            if (_locations.Count > 0)
            {
                Location previousLocation = _locations.Last();
                double distanceFromPreviousLocation = _distanceCalculator.GetDistance(previousLocation, location);
                Length += distanceFromPreviousLocation;
            }
            _locations.Add(location);
        }
    }
}
