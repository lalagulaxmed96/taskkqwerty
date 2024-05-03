using Core.Models;
using Core.RepositoryAbstracts;
using Data.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.RepositoryConcretes
{
    public class ProductRepository : IProductRepository
    {

        AppDbContext _appDbContext = new AppDbContext();
        public void Add(string command)
        {
            _appDbContext.NonQuery(command);
        }

        public void Delete(string command)
        {
            _appDbContext.NonQuery(command);
        }

        public Product Get(string command)
        {
            var dt = _appDbContext.Query(command);


            Product product = new Product
            {
                Id = int.Parse(dt.Rows[0].ToString()),
                Name = dt.Rows[1].ToString(),
                Price = decimal.Parse(dt.Rows[2].ToString())
            };
           
            return product[0];
        }

       

        List<Product> IProductRepository.Product(string command)
        {

            var dt = _appDbContext.Query(command);
            List <Product> products = new List<Product>();

           foreach(DataRow item in dt.Rows)
            {
                Product product = new Product
                {
                    Id = int.Parse(item[0].ToString()),
                    Name = item[1].ToString(),
                    Price = decimal.Parse(item[2].ToString())
                };

                return product;
            }
        }
    }
}
