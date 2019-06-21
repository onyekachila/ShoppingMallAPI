using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingMall.API.Domain.Models;
using ShoppingMall.API.Domain.Services;

namespace ShoppingMall.API.Controllers
{
    [Route("/api/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService; 

        public CategoriesController (ICategoryService categoryService)
        {
            _categoryService = categoryService; 
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> GetAll()
        {
            var categories = await _categoryService.ListAsync(); 
            return categories; 
        }



    }
}