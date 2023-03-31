using Models;

namespace EshopApplication.Interfaces
{
    public interface ICart
    {
        List<Cart> getCarts();

        Cart addItemsToCart(Cart cart_data);

        List<Cart> getCartProductsByUserId(int userId);

        void DeleteProduct(Cart id);

        Cart GetCartItem(int id);

    }
}
