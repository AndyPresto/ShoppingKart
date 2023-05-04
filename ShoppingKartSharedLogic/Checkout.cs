using ShoppingKartData;

namespace ShoppingKartSharedLogic
{
    public interface ICheckout
    {
        public void Scan(char item);

        public decimal GetTotalPrice();
    }

    public class Checkout : ICheckout
    {
        private readonly Dictionary<char, int> _scannedItems;
        private readonly Dictionary<char, Product> _products;
        
        public Checkout(IEnumerable<Product> products)
        {
            _products = new Dictionary<char, Product>();
            _scannedItems = new Dictionary<char, int>();
        
            foreach (var product in products)
            {
                _products[product.Sku] = product;
            }
        }
        
        public void Scan(char item)
        {
            if (_scannedItems.ContainsKey(item))
                _scannedItems[item]++;
            else
                _scannedItems[item] = 1;
        }
        
        public decimal GetTotalPrice()
        {
            decimal total = 0;
        
            foreach (var item in _scannedItems)
            {
                if (_products.TryGetValue(item.Key, out Product product))
                {
                    int itemCount = item.Value;
                    decimal itemPrice = product.Price;
        
                    if (product.Offer != null)
                    {
                        total += (itemCount / product.Offer.Quantity) * product.Offer.OfferPrice;
                        itemCount %= product.Offer.Quantity;
                    }
        
                    total += itemCount * itemPrice;
                }
            }
        
            return total;
        }
    }
}