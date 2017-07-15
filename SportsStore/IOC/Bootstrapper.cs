using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportsStore.Models.Repository;
using StructureMap;

namespace SportsStore.IOC
{
    public static class Bootstrapper
    {
        public static Container container;

        static Bootstrapper()
        {
            container = new Container(x =>
            {
                //x.For<IRepository>().Use<Repository>();
                x.For<IProductRepository>().Use<FakeProductRepository>();
            });
        }
    }
}
