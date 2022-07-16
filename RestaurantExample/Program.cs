using Autofac;
using RestaurantExample;
using RestaurantExample.Restaurant;

var container = ContainerConfig.Configure();

using (var scope = container.BeginLifetimeScope())
{
   // var employeeList = scope.Resolve<IEmployeesList>();
    var List = scope.Resolve<TestClasses>();
    var res = scope.Resolve<IRestaurant>();

    res.Rating = 10;
    res.Name = "Sana'a Restaurant";

    res.GetInfo();
    //IRestaurant restaurant = new Restaurants("Sana'a Restaurant", 10, );

   // restaurant.GetInfo();
   // List.getEmployees();
}
