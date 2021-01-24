using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Text;

namespace cours1
{
    class OrderItem
    {
        // Constructeurs:
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId, int productId , T purchasePrice, int quantity)
        {
            OrderItemId = orderItemId;
            ProductId = productId;
            PurchasePrice = purchasePrice;
            Quantity = quantity;
        }

        //Champs:

        //Propriétés:

        public int OrderItemId { get; set; }

        public int ProductId 
        { 
            get;
            private set;
        }
        public T PurchasePrice { get; set; }
        public int Quantity { get; set; }

        //Méthodes:

        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }
        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;
            if(Quantity>=0) isValid = false;
            if (ProductId >= 0) isValid = false;
            if (PurchasePrice != null) isValid = false;
            return isValid;
        }
             
    }
}


