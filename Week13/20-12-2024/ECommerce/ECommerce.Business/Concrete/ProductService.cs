using AutoMapper;
using ECommerce.Business.Abstract;
using ECommerce.Data.Abstract;
using ECommerce.Entity.Concrete;
using ECommerce.Shared.DTOs;
using ECommerce.Shared.ResponseDTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Product> _productRepository;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper, IGenericRepository<Product> productRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task<ResponseDTO<ProductDTO>> AddAsync(ProductCreateDTO productCreateDTO)
        {
            Product product = _mapper.Map<Product>(productCreateDTO);
            await _productRepository.AddAsync(product);
            await _unitOfWork.SaveChangesAsync();
            var result = await _unitOfWork.SaveChangesAsync();
            if (result <= 0)
            {
                return ResponseDTO<ProductDTO>.Fail("Ürün eklenirken bir hata oluştu", 500);
            }
            //Artık product veritabanına kaydedildiği için bir Id değerine sahip. Şimdi productCategories işlemlerini yapabiliriz.
            product.ProductCategories =
                productCreateDTO.CategoryIds.Select(categoryId => new ProductCategory
                {
                    CategoryId = categoryId,
                    ProductId = product.Id
                }).ToList();
            _productRepository.Update(product);
            result = await _unitOfWork.SaveChangesAsync();
            if (result <= 0)
            {
                return ResponseDTO<ProductDTO>.Fail("Ürün kategorileri eklenirken bir hata oluştu", 500);
            }
            var productDTO = _mapper.Map<ProductDTO>(product); 
            return ResponseDTO<ProductDTO>.Success(productDTO, 200);
        }

        public async Task<ResponseDTO<int>> DeleteAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null)
            {
                return ResponseDTO<int>.Fail("Ürün bulunamadı", 404);
            }
        }

        public Task<ResponseDTO<IEnumerable<ProductDTO>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO<IEnumerable<ProductDTO>>> GetAllAsync(bool? isActive)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO<IEnumerable<ProductDTO>>> GetAllWithCategoriesAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO<ProductDTO>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO<IEnumerable<ProductDTO>>> GetByCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO<int>> GetCountAsyn(bool? isActive)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO<int>> GetCountByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO<ProductDTO>> GetWithCategoriesAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO<NoContent>> UpdateAsync(ProductUpdateDTO productUpdateDTO)
        {
            throw new NotImplementedException();
        }
    }
}


















/*
 Business katmanına Service katmanı dendiğini de görebilirsiniz
 Abstract içindeki interfacelere IEntityNameService ismi sıkça verilirken,Concrete içindeki classlara ise entitynameService,EntityNameManager gibi isimler verilir.
*/