using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Services;

namespace Supermarket.API.Services
{
    public class CategoryService : ICategoryService
    {
        public Task<IEnumerable<Category>> ListAllCategoriesAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}