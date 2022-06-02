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
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IRepository<Product> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {
            return await _unitOfWork.Products.GetWithCategoryByIdAsync(productId);

         }
    }
}
