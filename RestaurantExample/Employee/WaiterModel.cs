﻿namespace RestaurantExample
{
    public class WaiterModel : Employee
    {
        public WaiterModel(string fname, string lname) : base (fname, lname)
        {
            Position = Positions.Waiter;
        }
    }
}
