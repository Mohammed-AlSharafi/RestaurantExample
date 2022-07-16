namespace RestaurantExample
{
    public class Badge : IBadge
    {
        public string GetEmployeeBadge(string fname, string lname, Positions position)
        {
            return($"{position} {fname.Substring(0, 1)}.{lname}");
        }
    }
}
