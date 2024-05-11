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
    public class ProductAndProductAttributeManager : BaseManager<ProductAndProductAttribute> , IProductAndProductAttributeManager
    {
        readonly IProductAndProductAttributeRepository _pPARep;
        public ProductAndProductAttributeManager(IProductAndProductAttributeRepository pPARep) : base(pPARep)
        {
            _pPARep = pPARep;
        }
    }
}
