using Autofac;
using RestaurantExample.Restaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantExample
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<EmployeesList>().As<IEmployeesList>();
            builder.RegisterType<Restaurants>().As<IRestaurant>();
            builder.RegisterType<ChefModel>().As<IEmployee>();
            builder.RegisterType<WaiterModel>().As<IEmployee>();
            builder.RegisterType<ManagerModel>().As<IEmployee>();
            builder.RegisterType<TestClasses>();

            return builder.Build();
        }
    }
}
