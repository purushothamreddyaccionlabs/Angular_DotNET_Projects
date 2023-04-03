using EshopApplication.DBContextLayer;
using EshopApplication.Interfaces;
using Models;

namespace EshopApplication.ServiceLayer
{
    public class OrdersServices: IOrders
    {
        private readonly EshopDB eshopDB;
        public OrdersServices(EshopDB eshopDB)
        {
            this.eshopDB = eshopDB;
        }

        public List<Orders> ListOfOrders()
        {
            return eshopDB.Orders.ToList();
        }
    }
}
