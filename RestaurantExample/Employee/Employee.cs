namespace RestaurantExample
{
    abstract class Employee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Positions Position { get; set; }

        public string GetBadge(IBadge badge)
        {
            return badge.GetEmployeeBadge(FirstName, LastName, Position);
        }
        public Employee(string fname, string lname)
        {
            FirstName = fname;
            LastName = lname;
        }
    }
}
