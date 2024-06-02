using Project.BLL.Managers.Abstracts;
using Project.BLL.ServiceInjections;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Managers.Concretes
{
    public class ProductManager : BaseManager<Product>, IProductManager
    {
        readonly IProductRepository _pRep;
        public ProductManager(IProductRepository pRep) : base(pRep)
        {
            _pRep = pRep;
        }

        public override List<Product> GetActives()
        {
            List<Product> products = _pRep.Where(x => x.UnitsInStock > 5);
            return products;
        }
        public override string Add(Product item)
        {
            item.ProductName = item.ProductName.ToTitleCase();
            return base.Add(item);
        }
        public override Task AddAsync(Product item)
        {
            item.ProductName = item.ProductName.ToTitleCase();
            return base.AddAsync(item);
        }
        public override Task UpdateAsync(Product item)
        {
            item.ProductName = item.ProductName.ToTitleCase();
            return base.UpdateAsync(item);
        }
    }
}
