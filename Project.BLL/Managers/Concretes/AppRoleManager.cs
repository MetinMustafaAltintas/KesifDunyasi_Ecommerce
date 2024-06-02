using Microsoft.EntityFrameworkCore.Query.Internal;
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
    public class AppRoleManager :BaseManager<AppRole>, IAppRoleManager
    {
        readonly IAppRoleRepository _arrep;
        public AppRoleManager(IAppRoleRepository aarep) : base(aarep)
        {
            _arrep = aarep;
        }

        public override string Add(AppRole item)
        {
            item.Name = item.Name.ToTitleCase();
            return base.Add(item);
        }
        public override Task AddAsync(AppRole item)
        {
            item.Name = item.Name.ToTitleCase();
            return base.AddAsync(item);
        }
        public override Task UpdateAsync(AppRole item)
        {
            item.Name = item.Name.ToTitleCase();
            return base.UpdateAsync(item);
        }
    }
}
