using System;
using System.Runtime.InteropServices;
using ECommerceBusiness.Concrete.Manager;
using ECommerceEntities.Entity;

namespace ECommerceConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product product1 = new Product();
            //product1.ProductId = 1;
            //product1.ProductCategory = "Computer";
            //product1.ProductName = "Asus Laptop";
            //product1.ProductPrice = 7999;
            //product1.isProductinStock = true;

            //Product product2 = new Product();
            //product2.ProductId = 2;
            //product2.ProductCategory = "Computer";
            //product2.ProductName = "Casper Laptop";
            //product2.ProductPrice = 5999;
            //product2.isProductinStock = false;

            //Product product3 = new Product();
            //product3.ProductId = 3;
            //product3.ProductCategory = "Phone";
            //product3.ProductName = "Iphone 12 Pro Max";
            //product3.ProductPrice = 11999;
            //product3.isProductinStock = true;

            //Product[] products = new Product[]
            //{
            //   product1,product2,product3
            //};

            //if (new Product()!=null)
            //{
            //    foreach (var item in products)
            //    {
            //        Console.WriteLine(item.ProductId + " " + item.ProductCategory + " " + item.ProductName + " " + item.ProductPrice + " " + item.isProductinStock);
            //    }

            //}

            Customer _customer1 = new Customer();
            _customer1.CustomerId = 1;
            _customer1.CustomerFirstName = "Muhammet";
            _customer1.CustomerLastName = "Yagiz";
            _customer1.CustomerAge = 25;

            Customer _customer2 = new Customer();
            _customer2.CustomerId = 2;
            _customer2.CustomerFirstName = "Kemal";
            _customer2.CustomerLastName = "Yagiz";
            _customer2.CustomerAge = 55;

            Customer[] customers = new Customer[]
            {
                _customer1,_customer2,
            };

            CustomerManager _customerManager = new CustomerManager();

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.CustomerFirstName + ' ' + customer.CustomerLastName + ' ' + customer.CustomerAge);
            }
            _customerManager.GetById();
        }
    }
}
