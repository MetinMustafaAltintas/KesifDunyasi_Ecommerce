using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class ProductAttribute : BaseEntity
    {
        public string AttributeName { get; set; }

        //Relational Properties

        public ICollection<AttributeValue> Values { get; set; }
    }
}
