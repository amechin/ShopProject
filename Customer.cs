using System;
namespace CoursNetCore1Myriam
{
    public class Customer
    {
        //Constructeurs
        public Customer()
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }

        //Champs
        private string _fullName;

        //Propriétés
        public int CustomerId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string FullName
        {
            get
            {
                string fullname = LastName;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullname))
                    {
                        fullname += ", ";
                    }
                    fullname += FirstName;
                }
                return fullname;
            }
        }


        //Methodes


    }
}
