using System;
using System.Collections.Generic;
using System.Text;

namespace cours1
{
    class Order
    {
        // Constructeurs:
        public Order()
        {
        
        }

        public Order(int orderId, DateTime orderDate)
        {
            OrderId = orderId;
            OrderDate = orderDate;
        }

        // Champs:


        // Proprietes:
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        //Methodes:
        public Order Retrieve(int orderId)
        {
            return new Order();
        }
            
        public bool Save()
        {
            return true;
        }
            
       public bool Validate(DateTime orderDate)
        {
            var isValid = true; 
            if (orderDate == null) isValid = false;
            return isValid;
        }


    }
}
