using EcommerceApp.Models;

namespace EcommerceApp.Interfaces
{
    public interface IClothes
    {
        List<Clothes> GetClothes();

        public Clothes CreateClothes(Clothes clothes);
    }
}
