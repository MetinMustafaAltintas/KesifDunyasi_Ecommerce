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
    //IdentityUser class'ı bir Identity class'ıdır...İndirdigimiz AspNetCore.Identity kütüphanesinden gelir... Ve bu sınıfı default kullanırsanız sınıf tabloya dönüstürülürken edinecegi primary key string tipte olur...Bizim sistemimizde tablolarımızın primary key'i int oldugu icin biz IdentityUser2in key'inin int olarak tanımlanmasını söylemeliyiz ki bu da IdentityUser sınıfını generic olarak kullanarak gerçekleştirilir...

    //Eger siz Identity kütüphanesindeki tablo yapılarını şekillendirmek istemezseniz hic AppUser class'ı acmadan işlemleri Identity'e bırakabilirsiniz...Kendisi bir AspNetUsers isimli tablo acarak bu işlemi yapacaktır...Ancak bilmelisiniz ki eger özel bir müdahale yapmazsanız tablonun primary key'i string olacaktır...

    //Bizim burada özellikle AppUser class'ı acma istegimiz Identity tarafındaki yapıları şekillendirmek (Kendi istedigimiz özel property'leri koymak, ilişkileri kendi tarafımızdaki class'lar ile saglamak vs...) istedigimiz icin kaynaklanmıstır...Dolayısıyla biz bu emri verdigimiz zaman Identity kütüphanesi hem kendi yapısını kendi property'leri ile olusturacak hem de bizim istedigimiz yapıları da icerisine entegre edecektir...
    public class AppUser : IdentityUser<int>, IEntity
    {
        public AppUser()
        {
            CreatedDate = DateTime.UtcNow;
            Status = DataStatus.Inserted;
        }
        public int ID { get; set; }
        public Guid? ActivationCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }

        //Relational Properties
        public virtual AppUserProfile Profile { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<AppUserRole> UserRoles { get; set; } //Property isminin UserRoles olmasına dikkat ediniz...


    }
}
