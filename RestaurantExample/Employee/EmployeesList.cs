namespace RestaurantExample
{
   public class EmployeesList : IEmployeesList
    {
        public EmployeesList()
        {

        }
        public List<IEmployee> GetEmployees()
        {
            return new List<IEmployee>()
            {
                new ManagerModel("John", "Smith"),
                new WaiterModel("James", "Long"),
                new ChefModel("Don", "Chris")
            };
        }
    }
}
