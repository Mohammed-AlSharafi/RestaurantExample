using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantExample.Restaurant
{
    public class TestClasses
    {
        private readonly IEmployeesList list;

        public TestClasses(IEmployeesList list)
        {
            this.list = list;
        }
       public IEmployeesList getEmployees()
        {
            return list;
        }
    }
}
