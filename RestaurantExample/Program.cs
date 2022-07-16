using Autofac;
using RestaurantExample;

var container = ContainerConfig.Configure();

using (var scope = container.BeginLifetimeScope())
{
    var restaurant = scope.Resolve<IRestaurants>();

    restaurant.GetInfo();
}