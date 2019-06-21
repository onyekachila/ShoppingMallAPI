using System.Collections.Generic;
using System.Threading.Tasks;
using ShoppingMall.API.Domain.Models;
using ShoppingMall.API.Domain.Services;

namespace ShoppingMall.API.Services
{
    public class CategoryService : ICategoryService
    {
        Task<IEnumerable<Category>> ICategoryService.ListAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}