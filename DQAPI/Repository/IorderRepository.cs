using DQAPI.Controllers;
using DQAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DQAPI.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order_tbl> GetAll();
    }


    public class OrderRepository : IOrderRepository
    {
        public IEnumerable<Order_tbl> GetAll()
        {
            DeliveryEntities db = new DeliveryEntities();
            return db.Order_tbl.Take(20);
        }
    }
}
