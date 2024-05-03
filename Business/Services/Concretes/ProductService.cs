using Business.Services.Abstracts;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Concretes
{
    public class ProductService: IProductService
    {
        IProductRepository _productRepository = new ProductRepository();
        private object product;

        public void AddProduct(Product products)
        {
            string command = $"Insert Into Products (Name,Price) values ('{product.Name}',{product.Price})";
            _productRepository.Add(command);
        }

        public void DeleteProduct(int id)
        {
            string command = $"DELETE FROM Products WHERE Id = {id}";
            _productRepository.Delete(command);
        }

        public List<Product> GetAllProducts()
        {
            string command = "SELECT * FROM Products";
            return _productRepository.GetAll(command);
        }

        public Product GetProduct(int id)
        {
            string command = $"SELECT * FROM Products WHERE Id = {id}";
            return _productRepository.Get(command);
        }

        public void UpdateProductt(int id, Product newStudent)
        {
            string command = $"SELECT * FROM Students WHERE Id = {id}";
            Product product = _productsRepository.Get(command);

            if (product == null) throw new NullReferenceException();

            product.Name = newProduct.Name;
            product.Price = newProduct.Price;

            string updateCommand = $"UPDATE Products SET Name = '{Name}', Price = {product.Price} WHERE Id = {id}";
            _productRepository.Update(updateCommand);
        }
}
