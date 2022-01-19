using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE1RoutingLib
{
    public class IdentifiableLocation : LocationBase
    {
        public string Id { get; }
        public IdentifiableLocation(double x, double y, string id) : base(x, y)
        {
            Id = id;
        }
    }
}
