using Autofac;
using RestaurantExample;

var container = ContainerConfig.Configure();

using (var scope = container.BeginLifetimeScope())
{
    var employeeList = scope.Resolve<IEmployeesList>();

    IRestaurant restaurant = new Restaurant("Sana'a Restaurant", 10, employeeList);

    restaurant.GetInfo();
}
