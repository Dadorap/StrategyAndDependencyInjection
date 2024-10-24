using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyOne.Strats
{
    public interface IRouteStrategy
    {
        string Name { get; set; }
        double CalculateRoute(double _route);
        
    }
}
