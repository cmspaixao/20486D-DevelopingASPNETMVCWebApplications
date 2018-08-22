﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CachingExample.Models;

namespace CachingExample.Data
{
    public class DbInitializer
    {
        public static void Initialize(ProductContext context)
        {
            context.Database.EnsureCreated();
            if (context.Products.Any())
            {
                return;
            }

            var products = new Product[]
            {
                new Product { Name = "Basketball", BasePrice= 5.5F, Description = "A spherical ball used in basketball games.", ImageName = "basketball" },
                new Product { Name = "Blue cupcake", BasePrice = 2.5F, Description = "Cupcake topped with Blue mysterious and delicous cream.", ImageName = "blue-cupcake" },
                new Product { Name = "Chocolate cupcake", BasePrice = 4F, Description = "Chocolate cupcakes topped with chocolate frosting.", ImageName = "chocolate-cupcake" },
                new Product { Name = "Traffic cone", BasePrice = 3F, Description = "An orange cone that is used to be placed on roads or footpaths.", ImageName = "traffic-cone" },
                new Product { Name = "Football", BasePrice = 2F, Description = "A ball inflated with air that is being played by using your feet.", ImageName = "football" }
            };

            foreach (Product p in products)
            {
                context.Products.Add(p);
            }

            context.SaveChanges();
        }
    }
}
