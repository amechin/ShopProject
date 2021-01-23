using System;
namespace CoursNetCore1Myriam
{
    public class Product
    {

        //constructeurs
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        //Champs

        //Propriétés
        public int ProductId
        {
            get;
            private set;
        }

        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        //Méthodes
        public Product Retrieve(int productId)
        {
            return new Product();
        }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }

        public bool Save()
        {
            return true;
        }
    }
}
