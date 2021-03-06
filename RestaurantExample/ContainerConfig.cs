using Autofac;
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

            builder.RegisterType<EmployeesStore>().As<IEmployeesStore>();
            builder.RegisterType<Restaurants>().As<IRestaurants>().WithParameter("name","Ahmed").WithParameter("rating", 5);
            builder.RegisterType<ChefModel>().As<IEmployee>();
            builder.RegisterType<WaiterModel>().As<IEmployee>();
            builder.RegisterType<ManagerModel>().As<IEmployee>();

            return builder.Build();
        }
    }
}
