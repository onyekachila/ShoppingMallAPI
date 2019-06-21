using System.Collections.Generic;
using System.Threading.Tasks;
using ShoppingMall.API.Domain.Models;

namespace ShoppingMall.API.Domain.Repositories
{
    public interface ICategoryRepository
    {
         Task<IEnumerable<Category>> ListAsync();
    }
}