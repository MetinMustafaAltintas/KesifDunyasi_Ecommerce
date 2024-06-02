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
    public class ShipperManager : BaseManager<Shipper>, IShipperManager
    {
        IShipperRepository _sRep;

        public ShipperManager(IShipperRepository sRep) : base(sRep)
        {
            _sRep = sRep;
        }

        public override string Add(Shipper item)
        {
            item.CompanyName = item.CompanyName.ToTitleCase();
            return base.Add(item);
        }
        public override Task AddAsync(Shipper item)
        {
            item.CompanyName = item.CompanyName.ToTitleCase();
            return base.AddAsync(item);
        }
        public override Task UpdateAsync(Shipper item)
        {
            item.CompanyName = item.CompanyName.ToTitleCase();
            return base.UpdateAsync(item);
        }
    }
}
