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
    public class CategoryManager : BaseManager<Category>, ICategoryManager
    {
        readonly ICategoryRepository _catRep;
        public CategoryManager(ICategoryRepository catRep) : base(catRep)
        {
            _catRep = catRep;
        }

        public override string Add(Category item)
        {
            item.CategoryName = item.CategoryName.ToTitleCase();
            return base.Add(item);
        }
        public override Task AddAsync(Category item)
        {
            item.CategoryName = item.CategoryName.ToTitleCase();
            return base.AddAsync(item);
        }
        public override Task UpdateAsync(Category item)
        {
            item.CategoryName = item.CategoryName.ToTitleCase();
            return base.UpdateAsync(item);
        }
    }
}
