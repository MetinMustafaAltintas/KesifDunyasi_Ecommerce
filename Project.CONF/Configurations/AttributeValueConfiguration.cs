using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Configurations
{
    public class AttributeValueConfiguration :BaseConfiguration<AttributeValue>
    {
        public override void Configure(EntityTypeBuilder<AttributeValue> builder)
        {
            base.Configure(builder);
        }
    }
}
