using MediafyAssignment.Interface;
using MediafyAssignment.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MediafyAssignment.Repositories
{
    public class ProductsRepositoryJson : IProductsRepository
    {
        public IEnumerable<Product> GetProductData()
        {
            string jsonFile;
            using (var r = new StreamReader(Path.Combine(Directory.GetCurrentDirectory(), "data\\products.json")))
            {
                jsonFile = r.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<List<Product>>(jsonFile);
        }
        public void UpdateProductData(IEnumerable<Product> UpdatedProducts)
        {
            var jsonFile = JsonConvert.SerializeObject(UpdatedProducts);
            File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "data\\products.json"), jsonFile, Encoding.UTF8);
        }
    }
}
