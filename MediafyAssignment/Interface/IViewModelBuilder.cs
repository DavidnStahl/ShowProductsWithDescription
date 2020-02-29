using MediafyAssignment.Models;
using MediafyAssignment.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediafyAssignment.Interface
{
    public interface IViewModelBuilder
    {
        ProductsViewModel BuildProductsViewModel(IEnumerable<Product> products);
    }
}
