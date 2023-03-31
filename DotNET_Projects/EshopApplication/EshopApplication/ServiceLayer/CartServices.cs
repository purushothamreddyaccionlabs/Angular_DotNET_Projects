using EshopApplication.DBContextLayer;
using EshopApplication.Interfaces;
using Models;
using System.Collections.Generic;

namespace EshopApplication.ServiceLayer
{
    public class CartServices:ICart
    {
        private readonly EshopDB Db;
        public CartServices(EshopDB db)
        {
            Db = db;
        }

        public Cart addItemsToCart(Cart cart_data)
        {
            Db.Cart.Add(cart_data);
            Db.SaveChanges();
            return (cart_data);
        }

        public void DeleteProduct(Cart Id)
        {
            Db.Cart.Remove(Id);
            Db.SaveChanges();
   
        }

        public Cart GetCartItem(int id)
        {
            var cartdata = Db.Cart.Find(id);
            return cartdata;
        }

        public List<Cart> getCartProductsByUserId(int userId)
        {
            List<Cart> TotalList = Db.Cart.ToList();
            List<Cart> productslist = new List<Cart>();
            foreach(Cart item in TotalList)
            {
                if(item.UserId == userId)
                {
                    productslist.Add(item);
                }
            }
            return productslist;
        }

        public List<Cart> getCarts()
        {
            return Db.Cart.ToList();
        }

        
    }
}
