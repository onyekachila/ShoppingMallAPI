using System.Collections.Generic;
using System.Threading.Tasks;
using ShoppingMall.API.Domain.Models;
using ShoppingMall.API.Domain.Services;
using ShoppingMall.API.Domain.Repositories; 

namespace ShoppingMall.API.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> ListAsync()
        { 
            return await _categoryRepository.ListAsync(); 
        }
    }
}