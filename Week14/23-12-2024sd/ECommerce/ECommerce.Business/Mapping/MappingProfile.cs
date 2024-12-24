using AutoMapper;
using ECommerce.Entity.Concrete;
using ECommerce.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            #region Category
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Category, CategoryCreateDTO>().ReverseMap();
            CreateMap<Category, CategoryUpdateDTO>().ReverseMap();
            #endregion

            #region Product
            CreateMap<Product, ProductDTO>()
                .ForMember(pDto => pDto.Categories, option => option
                    .MapFrom(p => p.ProductCategories.Select(pc => pc.Category)))
                .ReverseMap();
            CreateMap<Product, ProductCreateDTO>().ReverseMap();
            CreateMap<Product, ProductUpdateDTO>().ReverseMap();
            #endregion

        }
    }
}
