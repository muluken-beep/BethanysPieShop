namespace BethanysPieShop.Models
{
    public class IShoppingCart
    {
        void AddToCart(Pie pie);

        int RemoveFromCart(Pie pie);    

        List<ShoppingCartItem> GetShoppingCartItems();

        void ClearCart();

        decimal GetShoppingCartTotal();

        List<ShoppingCartItem> ShoppingCartItems { get; set; }  
    }
}
