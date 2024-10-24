using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyOne.Strats
{
    public class WalkingRouteStrategy : IRouteStrategy
    {
        public string Name { get; set; } = "Walking";

        public double CalculateRoute(double _route)
        {
            double walk = _route / 5 * 60;
            return walk;
        }
    }
}
