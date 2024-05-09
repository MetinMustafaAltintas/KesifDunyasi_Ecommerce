using Bogus.DataSets;
using Microsoft.EntityFrameworkCore;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Extensions
{
    public static class ProductAttributeDataSeedExtension
    {
        public static void SeedProductAttribute(ModelBuilder modelBuilder)
        {
            List<ProductAttribute> productAttributes = new();

            for (int i = 1; i < 11; i++)
            {
                ProductAttribute pA = new()
                {
                    ID = i,
                    AttributeName = new Commerce("tr").ProductMaterial()
                };
                productAttributes.Add(pA);
            }
            modelBuilder.Entity<ProductAttribute>().HasData(productAttributes);
        }
    }
}