using AutoMapper;
using blog.Categories;
using System;
using System.Collections.Generic;
using System.Text;

namespace blog
{
    public class categoryApplicationAutoMapperProfile : Profile
    {
        public categoryApplicationAutoMapperProfile()
        {
            CreateMap<blog.Categories.Category, CategoryDto>();
            //CreateMap<CreateUpdateCategoryDto, blog.Categories.Category>();

            CreateMap<CategoryDto, blog.Categories.Category>();
        }
    }
}
