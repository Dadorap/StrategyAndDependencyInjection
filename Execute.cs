using Autofac;
using StrategyOne.Strats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyOne
{
    public class Execute
    {
        public static void Run() 
        {
            // Set up the container
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterModule<Dinversion>();

            // Build the container
            var container = builder.Build();




            var r = container.Resolve<ReturnsContainer>();
            var way = r.Container(container, "walk");
            var routePlanner = container.Resolve<IRoutePlanner>() as RoutePlanner;

            // Dynamically set the route strategy to car
            routePlanner.SetRoute(way);
            routePlanner.GetRouteTime(50);  // Assume 50 miles of distance
        }
    }
}
