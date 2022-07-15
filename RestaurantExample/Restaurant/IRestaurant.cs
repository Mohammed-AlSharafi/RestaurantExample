namespace RestaurantExample
{
    interface IRestaurant
    {
        string Name { get; set; }
        int Rating { get; set; }
        List<IEmployee> Employees { get; set; }
        void GetInfo();
    }
}