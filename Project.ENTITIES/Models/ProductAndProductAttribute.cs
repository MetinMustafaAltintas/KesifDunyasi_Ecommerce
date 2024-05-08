using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class ProductAndProductAttribute :BaseEntity
    {
        public int ProductID { get; set; }
        public int ProductAttributeID { get; set; }
        public string Value { get; set; }

        // Relational Properties

        public virtual Product  Product { get; set; }
        public virtual ProductAttribute ProductAttribute { get; set; }
    }
}
