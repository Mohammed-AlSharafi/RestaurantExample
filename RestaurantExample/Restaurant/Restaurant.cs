namespace RestaurantExample
{
  public class Restaurants : IRestaurant
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public List<IEmployee> Employees { get; set; }

        //public Restaurants(IEmployeesList employees)
        //{
        //    //Name = name;
        //    //Rating = rating;
        //    Employees = employees.GetEmployees();
        //}
        public void GetInfo()
        {
            Console.WriteLine($"{Name} ({Rating}/10 Ratings)\nEmployees:");
            foreach(var employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}, {employee.Position}, Badge: {employee.GetBadge(new Badge())}");
            }
            Console.WriteLine();
        }
    }
}
