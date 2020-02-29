using MediafyAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediafyAssignment.Interface
{
    public interface IProductsRepository
    {
        IEnumerable<Product> GetProductData();
        void UpdateProductData(IEnumerable<Product> UpdatedProducts);
    }
}
