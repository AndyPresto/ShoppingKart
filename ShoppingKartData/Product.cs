using System;

namespace ShoppingKartData
{
    public class Product
    {
        public char Sku { get; set; }
        public decimal Price { get; set; }
        public Offer Offer { get; set; }

        public Product(char sku, decimal price, Offer offer = null)
        {
            Sku = sku;
            Price = price;
            Offer = offer;
        }
    }
}