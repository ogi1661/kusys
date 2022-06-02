using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestProje.Core.Models;

namespace TestProje.Core.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<Category> GetWithProductsByIdAsync(int categoryId);
    }
}
