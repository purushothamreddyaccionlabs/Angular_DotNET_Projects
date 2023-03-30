using EshopApplication.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace EshopApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : Controller
    {
        private readonly ICart _ICart;
        public CartController(ICart icart)
        {
            _ICart = icart;
        }
        [HttpGet]
        [Route("GetCartItems")]
        public IActionResult GetCartItems()
        {
            var cartList = _ICart.getCarts();

            return Ok(cartList);
        }

        [HttpPost]
        [Route("AddToCart")]
        public IActionResult AddToCart(Cart cart_data)
        {
            _ICart.addItemsToCart(cart_data);
            return Created("/" + cart_data.Id,cart_data);
        }

        [HttpGet]
        [Route("GetProductsBy{userId}")]
        public IActionResult GetProductsByUserId(int userId)
        {
            var itemsList = _ICart.getCartProductsByUserId(userId);
            return Ok(itemsList);
        }
    }
}
