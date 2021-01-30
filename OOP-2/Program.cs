using System;

namespace OOP_2
{
    class Program
    {
        static void Main(string[] args)
        {

            RealCustomer realCustomer = new RealCustomer();
            realCustomer.CustomerId = 1;
            realCustomer.CustomerNo = "12345";
            realCustomer.CustomerName = "Samet";
            realCustomer.CustomerLastName = "kaya";
            realCustomer.CustomerTcNo = "12345678910";


            LegalCustomer legalCustomer = new LegalCustomer();

            legalCustomer.CustomerId = 2;
            legalCustomer.CustomerNo = "12345";
            legalCustomer.CustomerCompanyName = "Kodhanem";
            legalCustomer.CustomerTaxNo="1234567890";



            // Gerçek Müşteri - Tüzel Müşteri
            // SOLID 

            Customer customer1 = new RealCustomer();
            Customer customer2 = new LegalCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(realCustomer);
            customerManager.Add(legalCustomer);

        }
    }
}
