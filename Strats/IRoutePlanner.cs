using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyOne.Strats
{
    public interface IRoutePlanner
    {

        void GetRouteTime(double _route);
        void SetRoute(IRouteStrategy _route);
    }
}
