namespace RestaurantExample
{
    class ChefModel : Employee
    {
        public ChefModel(string fname, string lname) : base (fname, lname)
        {
            Position = Positions.Chef;
        }
    }
}
