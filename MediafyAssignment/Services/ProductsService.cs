using MediafyAssignment.Builders;
using MediafyAssignment.Interface;
using MediafyAssignment.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediafyAssignment.Services
{
    public class ProductsService : IProductsService
    {
        public ProductsViewModel GetDataToShow(IProductsRepository repository, IViewModelBuilder viewModelBuilder)
        {
            return viewModelBuilder.BuildProductsViewModel(repository.GetProductData());
        }
    }
}
