using System.Collections.Generic;

namespace P2FixAnAppDotNetCode.Models
{
    public interface ICart
    {
        List<CartLine> Items { get; }
        IEnumerable<CartLine> Lines { get; }
        void AddItem(Product product, int quantity);
        void RemoveLine(Product product);
        void Clear();
    }
}