using MediafyAssignment.Interface;
using MediafyAssignment.Models;
using MediafyAssignment.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediafyAssignment.Builders
{
    public class ViewModelBuilder : IViewModelBuilder
    {
        public ProductsViewModel BuildProductsViewModel(IEnumerable<Product> products)
        {
            var model = new ProductsViewModel();
            model.Products = products.ToList();
            return model;
        }
    }
}
