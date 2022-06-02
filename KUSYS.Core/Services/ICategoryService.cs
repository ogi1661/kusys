using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestProje.Core.Models;

namespace TestProje.Core.Services
{
    public interface ICategoryService : IService<Category>
    {
        Task<Category> GetWithProductsByIdAsync(int categoryId);

        //Category özgü methodlarınız varsa burada tanımlayabilirsiniz.
    }
}
