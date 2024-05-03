using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.RepositoryAbstracts
{
    public interface IProductRepository
    {
        void Add(string command);
        void Delete(string command);
        Product Get(string command);
        List<Product> Products(string command); 
    }
}
