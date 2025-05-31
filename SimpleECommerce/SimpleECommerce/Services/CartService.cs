using SimpleECommerce.Models;

namespace SimpleECommerce.Services;

public class CartService
{
    public List<CartItem> Items { get; set; } = new();

    public void AddToCart(Product product)
    {
        var item = Items.FirstOrDefault(i => i.Product.Id == product.Id);
        if (item != null)
            item.Quantity++;
        else
            Items.Add(new CartItem { Product = product, Quantity = 1 });
    }

    public void RemoveFromCart(Product product)
    {
        var item = Items.FirstOrDefault(i => i.Product.Id == product.Id);
        if (item != null)
        {
            Items.Remove(item);
        }
    }

    public void ClearCart() => Items.Clear();
}
