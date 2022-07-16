namespace RestaurantExample
{
    class Restaurants : IRestaurants
    {
        private readonly IEmployeesStore employees;

        public string Name { get; set; }
        public int Rating { get; set; }
        public List<IEmployee> Employees { get; set; }

        public Restaurants(string name, int rating, IEmployeesStore employees)
        {
            Name = name;
            Rating = rating;
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
