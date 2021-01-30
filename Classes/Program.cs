using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();

            customer.City="İstanbul";
            customer.Id = 1;
            customer.FirstName = "samet";
            customer.LastName = "Kaya";

            Customer customer2 = new Customer
            {
                City = "İstanbul",
                Id = 2,
                FirstName = "Mazlum",
                LastName = "Arslan"
                
            };

            Console.WriteLine(customer.FirstName);
        }
    }
}
