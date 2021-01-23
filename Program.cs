using System;

namespace CoursNetCore1Myriam
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Customer customer1 = new Customer();
            Customer customer2 = new Customer(1);

            customer1.FirstName = "client1";
            customer1.LastName = "";
            Console.WriteLine(customer1.FullName);
        }
    }
}
