using Microsoft.AspNetCore.Mvc;
using ShoppingApplication.Interfaces;
using ShoppingApplication.Models;

namespace ShoppingApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private IProduct _products;
        public ProductController(IProduct products)
        {
            _products = products;
        }

        [HttpGet]
        [Route("GetProducts")]
        public IActionResult GetProducts()
        {
            var result = _products.GetProduct();
            return Ok(result);
        }

        [HttpPost]
        [Route("AddProduct")]
        public IActionResult CreateProduct(product product) 
        {
            _products.createproducts(product);
            return Created("/" + product.Id, product);
        }

        [HttpDelete]
        [Route("DeleteProduct/{proId}")]
        public IActionResult DeleteProduct(int proId)
        {
            var pId = _products.GetProduct(proId);
            if(pId != null) 
            {
                _products.Delete(pId);
                return Ok();
            }
            return NotFound($"Not found with {proId}");
        }

        [HttpPut]
        [Route("EditProduct/Edit/{proId}")]
        public IActionResult Edit(int proId,product data)
        {
            var existingProduct = _products.GetProduct(proId);
            if(existingProduct != null)
            {
                proId = existingProduct.Id;
                _products.EditProduct(data);
            }
            return Ok(data);
        }



    }
}
