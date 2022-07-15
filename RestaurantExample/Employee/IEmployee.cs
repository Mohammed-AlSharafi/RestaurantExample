namespace RestaurantExample
{
    interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        Positions Position { get; set; }
        string GetBadge(IBadge badge);
    }
}
