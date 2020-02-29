using MediafyAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediafyAssignment.ViewModels
{
    public class ProductsViewModel
    {
        public List<Product> Products { get; set; }

        public ProductsViewModel()
        {
            Products = new List<Product>();
        }
    }
}
