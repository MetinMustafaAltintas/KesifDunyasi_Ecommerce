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
    public static class ProductAndProductAttributeDataSeedExtension
    {
        public static void ProductAndProductAttribute(ModelBuilder modelBuilder)
        {
            List<ProductAndProductAttribute> productAndProductAttribute = new();

            for (int i = 0; i < 11; i++)
            {
                ProductAndProductAttribute pPA = new()
                {
                    ProductAttributeID = i,
                    ProductID = i,
                    Value = new Commerce("tr").ProductDescription()
                };
                productAndProductAttribute.Add(pPA);
            }
            modelBuilder.Entity<ProductAndProductAttribute>().HasData(productAndProductAttribute);
        }
    }
}