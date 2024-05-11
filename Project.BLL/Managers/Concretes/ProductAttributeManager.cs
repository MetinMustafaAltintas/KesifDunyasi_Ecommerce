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
    public class ProductAttributeManager : BaseManager<ProductAttribute>, IProductAttributeManager
    {
        readonly IProductAttributeRepository _pARep;
        public ProductAttributeManager(IProductAttributeRepository pARep) : base(pARep)
        {
            _pARep = pARep;
        }
    }
}
