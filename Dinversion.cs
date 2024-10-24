using Autofac;
using StrategyOne.Strats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyOne
{
    public class Dinversion : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarRouteStrategy>().Keyed<IRouteStrategy>("car");
            builder.RegisterType<BikeRouteStrategy>().Keyed<IRouteStrategy>("bike");
            builder.RegisterType<WalkingRouteStrategy>().Keyed<IRouteStrategy>("walk");
            builder.RegisterType<RoutePlanner>().As<IRoutePlanner>();
            builder.RegisterType<ReturnsContainer>().AsSelf();


        }
    }
}
