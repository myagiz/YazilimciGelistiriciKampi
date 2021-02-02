using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceBusiness.Abstract;

namespace ECommerceBusiness.Concrete.Manager
{
    public class CustomerManager:ICustomerService
    {
        public void Add()
        {
           Console.WriteLine("Customer Added!");
        }

        public void Delete()
        {
            Console.WriteLine("Customer Deleted!");
        }

        public void Update()
        {
           Console.WriteLine("Customer Updated!");
        }

        public void GetById()
        {
            Console.WriteLine("Customer Information");
        }
    }
}
