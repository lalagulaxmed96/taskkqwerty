using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Abstracts
{
    internal interface IProductService
    {
        void DeleteStudent(int id);
        void AddStudent(Product product);
        void UpdateStudent(int id, Product newProduct);

        Product GetProduct(int id);
        List<Product> GetAllProducts();

    }
}
