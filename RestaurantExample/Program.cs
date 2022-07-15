using RestaurantExample;

var container = ContainerConfig.Configure();

IRestaurant restaurant = new Restaurant("Sana'a Restaurant", 10, new EmployeesList());

restaurant.GetInfo();
