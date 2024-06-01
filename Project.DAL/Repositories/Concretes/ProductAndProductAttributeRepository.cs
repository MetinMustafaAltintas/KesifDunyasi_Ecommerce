using Bogus.Bson;
using Microsoft.EntityFrameworkCore;
using Project.DAL.ContextClasses;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repositories.Concretes
{
    public class ProductAndProductAttributeRepository : BaseRepository<ProductAndProductAttribute>, IProductAndProductAttributeRepository
    {
        public ProductAndProductAttributeRepository(MyContext db) : base(db)
        {
        }

       

    }
}
