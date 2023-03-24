using EcommerceApp.Interfaces;
using EcommerceApp.Models;
using EcommerceApp.RepositoryLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApp.Controllers
{
    
    [ApiController]
    public class ClothesController : ControllerBase
    {
        private IClothes _clothes;
        public ClothesController(IClothes clothes)
        {
            _clothes = clothes;
        }

        //Get: api/Clothes
        [HttpGet]
        [Route("api/controller")]
        public IActionResult GetClothes()
        {
            var getclothes = _clothes.GetClothes();
            return Ok(getclothes);
        }

        //post: api/clothes
        [HttpPost]
        [Route("api/controller")]
        public IActionResult CreateClothes(Clothes clothes)
        {
            _clothes.CreateClothes(clothes);
            return Created("/" + clothes.Id,clothes);
        }



    }
    

}




 
