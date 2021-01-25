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

        public bool Validate(int quantity, int productId, T purchasePrice)
        {
            var isValid = true;
            if(quantity>=0) isValid = false;
            if (productId >= 0) isValid = false;
            if (purchasePrice != null) isValid = false;
            return isValid;
        }
             
    }
}


