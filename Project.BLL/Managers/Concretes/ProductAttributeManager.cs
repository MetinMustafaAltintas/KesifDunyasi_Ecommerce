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
    public class ProductAttributeManager : BaseManager<ProductAttribute>, IProductAttributeManager
    {
        readonly IProductAttributeRepository _pARep;
        public ProductAttributeManager(IProductAttributeRepository pARep) : base(pARep)
        {
            _pARep = pARep;
        }
        public override string Destroy(ProductAttribute item)
        {
            
            _iRep.Destroy(item);
            return "Veri basarıyla yok edildi";
        }

        public override string Add(ProductAttribute item)
        {
            item.AttributeName = item.AttributeName.ToTitleCase();
            return base.Add(item);
        }
        public override Task AddAsync(ProductAttribute item)
        {
            item.AttributeName = item.AttributeName.ToTitleCase();
            return base.AddAsync(item);
        }
        public override Task UpdateAsync(ProductAttribute item)
        {
            item.AttributeName = item.AttributeName.ToTitleCase();
            return base.UpdateAsync(item);
        }
    }
}
