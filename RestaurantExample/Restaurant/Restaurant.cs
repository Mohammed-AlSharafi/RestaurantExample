namespace RestaurantExample
{
  public class Restaurants : IRestaurant
    {
        private readonly IEmployeesList employees;

        public string Name { get; set; }
        public int Rating { get; set; }
        public List<IEmployee> Employees { get; private set; }

        public Restaurants(IEmployeesList employees)
        {
            this.employees = employees;
        }

        public void GetInfo()
        {
            Employees = employees.GetEmployees();
            Console.WriteLine($"{Name} ({Rating}/10 Ratings)\nEmployees:");
            foreach(var employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}, {employee.Position}, Badge: {employee.GetBadge(new Badge())}");
            }
            Console.WriteLine();
        }
    }
}
