namespace RestaurantExample
{
    public class ManagerModel : Employee
    {
        public ManagerModel(string fname, string lname) : base (fname, lname)
        {
            Position = Positions.Manager;
        }
    }
}
