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
    }
}
