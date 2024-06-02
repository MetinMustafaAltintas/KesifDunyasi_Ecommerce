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
    public class AppUserManager : BaseManager<AppUser>, IAppUserManager
    {
        readonly IAppUserRepository _appRep;
        public AppUserManager(IAppUserRepository appRep) : base(appRep)
        {
            _appRep = appRep;
        }
        public async Task<bool> AddUser(AppUser user)
        {
            return await _appRep.AddUser(user);
        }
        public override string Add(AppUser item)
        {
            item.UserName = item.UserName.ToTitleCase();
            return base.Add(item);
        }
        public override Task UpdateAsync(AppUser item)
        {
            item.UserName = item.UserName.ToTitleCase();
            return base.UpdateAsync(item);
        }
        public override Task AddAsync(AppUser item)
        {
            item.UserName = item.UserName.ToTitleCase();
            return base.AddAsync(item);
        }
    }
}
