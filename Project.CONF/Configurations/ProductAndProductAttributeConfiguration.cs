using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Configurations
{
    public class ProductAndProductAttributeConfiguration :BaseConfiguration<ProductAndProductAttribute>
    {
        public override void Configure(EntityTypeBuilder<ProductAndProductAttribute> builder)
        {
            base.Configure(builder);
            builder.Ignore(x => x.ID);
            builder.HasKey(x => new
            {
                x.ProductAttributeID,
                x.ProductID
            });
        }
    }
}
