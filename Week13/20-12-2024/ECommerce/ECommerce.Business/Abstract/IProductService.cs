﻿using ECommerce.Shared.DTOs;
using ECommerce.Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface IProductService
    {
        Task<ResponseDTO<ProductDTO>> GetAsync(int id);
        Task<ResponseDTO<ProductDTO>> GetWithCategoriesAsync(int id);
        Task<ResponseDTO<IEnumerable<ProductDTO>>> GetAllAsync();
        Task<ResponseDTO<IEnumerable<ProductDTO>>> GetAllAsync(bool? isActive);
        Task<ResponseDTO<IEnumerable<ProductDTO>>> GetAllWithCategoriesAsync(int categoryId); //aktif olanlar
        Task<ResponseDTO<IEnumerable<ProductDTO>>> GetByCategoryAsync(int categoryId);//Aktif olanlar
        Task<ResponseDTO<ProductDTO>> AddAsync(ProductCreateDTO productCreateDTO);
        Task<ResponseDTO<NoContent>> UpdateAsync(ProductUpdateDTO productUpdateDTO);
        Task<ResponseDTO<int>> DeleteAsync(int id);
        Task<ResponseDTO<int>> GetCountAsyn(bool? isActive);
        Task<ResponseDTO<int>> GetCountByCategory(int categoryId);




    }
}