using Project.BLL.Managers.Abstracts;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Managers.Concretes
{
    public class OrderManager : BaseManager<Order>, IOrderManager
    {
        readonly IOrderRepository _oRep;
        public OrderManager(IOrderRepository oRep) : base(oRep)
        {
            _oRep = oRep;
        }

        public override string Add(Order item)
        {
            return base.Add(item);
        }

        public override Task AddAsync(Order item)
        {
            return base.AddAsync(item);
        }
    }
}