namespace RestaurantExample
{
   public interface IRestaurant
    {
        string Name { get; set; }
        int Rating { get; set; }
        List<IEmployee> Employees { get; }
        void GetInfo();
    }
}