using Microsoft.AspNetCore.Identity;
using Project.ENTITIES.CoreInterfaces;
using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class AppUserRole : IdentityUserRole<int>, IEntity
    {
        //AppUserRole sınıfında Relational Property isimlerine cok dikkat ediniz...Bunların hepsi Identity'nin istedigi standartlara uygun verilmiştir...Cok dikkat edin eger bu Relation'lara müdahale edecekseniz bizzat Identity standartlarına uyun...

        //Identity standartlarında normalde ilişkisel Property User,Role olarak istenir..UserId ve RoleId property'lerine gerek yoktur cünkü onlar zaten miras olarak gelmektedir...Relational Property'leri de bu yüzden User ve Role olarak veririz...
        public AppUserRole()
        {
            Status = DataStatus.Inserted;
            CreatedDate = DateTime.Now;

        }
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }

        // Relational Properties

        public virtual AppUser User { get; set; } //Property isminin User olduguna dikkat edin...Cünkü UserId property'sinden kaynaklanmaktadır...

        public virtual AppRole Role { get; set; }
    }
}
