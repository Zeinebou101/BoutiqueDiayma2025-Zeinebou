using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;

namespace P2FixAnAppDotNetCode.Models
{
    public class Cart : ICart
    {
        private readonly ISession _session;
        private const string SessionKey = "cart.session";

        public Cart(IHttpContextAccessor httpContextAccessor)
        {
            _session = httpContextAccessor.HttpContext.Session;
            Items = _session.GetObject<List<CartLine>>(SessionKey) ?? new List<CartLine>();
        }

        public List<CartLine> Items { get; private set; }

        // compatibilité avec le reste du code qui utilise "Lines"
        public IEnumerable<CartLine> Lines => Items;

        public void AddItem(Product product, int quantity)
        {
            var line = Items.FirstOrDefault(l => l.Product.Id == product.Id);
            if (line == null)
            {
                Items.Add(new CartLine { Product = product, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
            Persist();
        }

        public void RemoveLine(Product product)
        {
            var line = Items.FirstOrDefault(l => l.Product.Id == product.Id);
            if (line != null)
            {
                Items.Remove(line);
                Persist();
            }
        }

        public void Clear()
        {
            Items.Clear();
            Persist();
        }

        private void Persist()
        {
            _session.SetObject(SessionKey, Items);
        }
    }

    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}