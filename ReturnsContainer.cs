using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using StrategyOne.Strats;


namespace StrategyOne
{
    public class ReturnsContainer
    {

        public IRouteStrategy Container(IContainer _container, string s)
        {
            IRouteStrategy car = _container.ResolveKeyed<IRouteStrategy>("car");
            IRouteStrategy bike = _container.ResolveKeyed<IRouteStrategy>("bike");
            IRouteStrategy walk = _container.ResolveKeyed<IRouteStrategy>("walk");

            switch (s)
            {
                case "car":
                    return car;
                    break;
                case "bike":
                    return bike;
                    break;
                case "walk":
                    return walk;
                    break;
                default:
                    break;
            }
            return null;
        }
    }
}
