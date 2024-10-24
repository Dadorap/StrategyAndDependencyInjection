using StrategyOne.Strats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyOne
{
    public class RoutePlanner : IRoutePlanner
    {
       static IRouteStrategy _routeStrategy;

        public  void SetRoute (IRouteStrategy _routeStrat)
        {
            _routeStrategy = _routeStrat;
        }
        public void GetRouteTime(double _route)
        {
            Console.WriteLine($"Traveling by {_routeStrategy.Name} will take {_routeStrategy.CalculateRoute(_route)} minutes.");
        }
    }
}
