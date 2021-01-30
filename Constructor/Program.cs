using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer 
            {
             Id=1,
             FirstName="kayahan",
             LastName="Kaya",
             City="istanul"
            };

            Customer customer2 = new Customer 
            (
                2, 
                "hayati",
                "Arslan", 
                "Ankara"
            );
            
            Console.WriteLine(customer1.City);
            Console.WriteLine(customer2.City);
        }
        
    }
    class Customer
    {
        public Customer()
        {
                
        }
        public Customer(int id, string firstName, string lastName, string city)
        {

            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

            Console.WriteLine(Id+" "+FirstName + " " + LastName + " " + City);
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
