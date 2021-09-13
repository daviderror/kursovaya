﻿using System;
using System.Collections.Generic;
using System.Text;
using DataLib.Sqlite.Model;

namespace mobileClient.Models
{
    public class ProductListElement
    {
        private Product _product;
        public ProductListElement(Product product, double weight)
        {
            _product = product;
            Weight = weight;
        }

        public string Name => _product.Name;
        public double Calories => _product.Calories;
        public double Weight { get; set; }
        public double TotalCalories => Calories * Weight;
    }
}
