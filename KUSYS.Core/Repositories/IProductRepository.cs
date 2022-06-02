using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestProje.Core.Models;

namespace TestProje.Core.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> GetWithCategoryByIdAsync(int productId);
    }
}
