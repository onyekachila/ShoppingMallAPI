using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShoppingMall.API.Domain.Models;
using ShoppingMall.API.Domain.Services;
using ShoppingMall.API.Resources;

namespace ShoppingMall.API.Controllers
{
    [Route("/api/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService; 
        private readonly IMapper _mapper;

        public CategoriesController (ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService; 
            _mapper = mapper; 
        }

        [HttpGet]
        public async Task<IEnumerable<CategoryResource>> GetAllAsync()
        {
            var categories = await _categoryService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryResource>>(categories);
            
            return resources;
        }



    }
}