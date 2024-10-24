using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyOne.Strats
{
    public class BikeRouteStrategy : IRouteStrategy
    {
        public string Name { get; set; } = "Bike";

        public double CalculateRoute(double _route)
        {
            double bike = _route / 15 * 60;
            return bike;
        }
    }
}
