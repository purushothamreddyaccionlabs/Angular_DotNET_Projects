using EcommerceApp.Interfaces;
using EcommerceApp.Models;
using EcommerceApp.RepositoryLayer;

namespace EcommerceApp.ServiceLayer
{
    public class ClothesService : IClothes
    {
        private readonly ApplicationDbContext _Db;

        public ClothesService(ApplicationDbContext clothes)
        {
            _Db = clothes;
        }

        public List<Clothes> GetClothes()
        {
            return _Db.clothes.ToList();
        }

        public Clothes CreateClothes(Clothes clothes)
        {
            _Db.clothes.Add(clothes);
            _Db.SaveChanges();
            return clothes;
        }
    }
}
