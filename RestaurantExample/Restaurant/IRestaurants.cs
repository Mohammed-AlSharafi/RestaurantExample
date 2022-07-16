namespace RestaurantExample
{
    interface IRestaurants
    {
        string Name { get; set; }
        int Rating { get; set; }
        List<IEmployee> Employees { get; set; }
        void GetInfo();
    }
}