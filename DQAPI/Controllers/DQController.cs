using DQAPI.Models;
using DQAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DQAPI.Controllers
{
    public class DQController : ApiController
    {
        private IOrderRepository _OrderRepository = null;
        public DQController(IOrderRepository repo)
        {
            _OrderRepository = repo;
        }
        public IEnumerable<Order_tbl> Get()
        {
            return _OrderRepository.GetAll();
        }
    }
}
