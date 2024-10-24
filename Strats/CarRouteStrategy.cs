using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyOne.Strats
{
    public class CarRouteStrategy : IRouteStrategy
    {
        public string Name { get; set; } = "Car";

        public double CalculateRoute(double _route)
        {
            double car = _route / 100 * 60;
            return car;
        }
    }
}
