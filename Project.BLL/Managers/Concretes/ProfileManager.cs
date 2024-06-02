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
    public class ProfileManager : BaseManager<AppUserProfile>, IProfileManager
    {
        readonly IProfileRepository _proRep;
        public ProfileManager(IProfileRepository proRep) : base(proRep)
        {
            _proRep = proRep;
        }

        public override string Add(AppUserProfile item)
        {
            item.FirstName = item.FirstName.ToTitleCase();
            item.LastName = item.LastName.ToTitleCase();
            return base.Add(item);
        }
        public override Task AddAsync(AppUserProfile item)
        {
            item.FirstName = item.FirstName.ToTitleCase();
            item.LastName = item.LastName.ToTitleCase();
            return base.AddAsync(item);
        }
        public override Task UpdateAsync(AppUserProfile item)
        {
            item.FirstName = item.FirstName.ToTitleCase();
            item.LastName = item.LastName.ToTitleCase();
            return base.UpdateAsync(item);
        }
    }
}
