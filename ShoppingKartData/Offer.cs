using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingKartData
{
    public class Offer
    {
        public int Quantity { get; set; }
        public decimal OfferPrice { get; set; }

        public Offer(int quantity, decimal offerPrice)
        {
            Quantity = quantity;
            OfferPrice = offerPrice;
        }
    }
}
