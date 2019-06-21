using AutoMapper;
using ShoppingMall.API.Domain.Models;
using ShoppingMall.API.Resources;

namespace ShoppingMall.API.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();            
        }
    }
}