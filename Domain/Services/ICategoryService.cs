using System.Collections.Generic;
using System.Threading.Tasks;
using ShoppingMall.API.Domain.Models;

namespace ShoppingMall.API.Domain.Services
{
    public interface ICategoryService
    {
         Task<IEnumerable<Category>> ListAsync();
    }
}