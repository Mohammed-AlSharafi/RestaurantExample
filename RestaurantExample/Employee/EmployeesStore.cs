namespace RestaurantExample
{
    class EmployeesStore : IEmployeesStore
    {
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
