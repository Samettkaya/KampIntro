using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance   // Kalıtım 
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();


            Person[] persons = new Person[3]
            {
                new Customer{FristName="samet" },new Student{FristName="Kayahan" },new Person{FristName="salih"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FristName);
            }
            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
    }

   
    class Customer:Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }
}
  