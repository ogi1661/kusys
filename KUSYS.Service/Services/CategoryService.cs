using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestProje.Core.Models;
using TestProje.Core.Repositories;
using TestProje.Core.Services;
using TestProje.Core.UnitOfWorks;

namespace TestProje.Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IRepository<Category> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Category> GetWithProductsByIdAsync(int categoryId)
        {
            return await _unitOfWork.categories.GetWithProductsByIdAsync(categoryId);
             
        }
    }
}
