using AutoMapper;
using ECommerce.Business.Abstract;
using ECommerce.Data.Abstract;
using ECommerce.Entity.Concrete;
using ECommerce.Shared.DataTransferObjects;
using ECommerce.Shared.ResponseDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }



        public async Task<ResponseDTO<CategoryDTO>> AddAsync(CategoryCreateDTO categoryCreateDTO)
        {
            Category category = _mapper.Map<Category>(categoryCreateDTO);
            await _unitOfWork.GetRepository<Category>().AddAsync(category);
            var result = await _unitOfWork.SaveChangesAsync();
            if(result<=0)//Eğer kayıt gerçekleşmemiş ise
            {
                return ResponseDTO<CategoryDTO>.Fail("Bir hata oluştu!", 500);
            }
            CategoryDTO categoryDTO = _mapper.Map<CategoryDTO>(category);
            return ResponseDTO<CategoryDTO>.Success(categoryDTO,201);
        }
        

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        public Task<ResponseDTO<int>> CountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO<NoContent>> DeleteAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDTO<IEnumerable<CategoryDTO>>> GetAllAsync()
        {
            var categories = await _unitOfWork.GetRepository<Category>().GetAllAsync();
            if(categories == null)
            {
                return ResponseDTO<IEnumerable<CategoryDTO>>.Fail("Sunucuda bir sorun oluştu daha sonra tekrar deneyiniz", 500);

            }
            if(categories.Count() == 0)
            {
                return ResponseDTO<IEnumerable<CategoryDTO>>.Fail("Hiç bir kategori bulunamadı!",StatusCodes.Status404NotFound);
            }
            var categoryDTOs = _mapper.Map<IEnumerable<CategoryDTO>>(categories);
            return ResponseDTO<IEnumerable<CategoryDTO>>.Success(categoryDTOs, StatusCodes.Status200OK);
        }

        public async Task<ResponseDTO<CategoryDTO>> GetAsync(int id)
        {
            var category = await _unitOfWork.GetRepository<Category>().GetByIdAsync(id);
            if(category == null)
            {
                return ResponseDTO<CategoryDTO>.Fail("İlgili kategori bulunamadı", StatusCodes.Status404NotFound);
            }
            var categoryDTO = _mapper.Map<CategoryDTO>(category);
            return ResponseDTO<CategoryDTO>.Success(categoryDTO, StatusCodes.Status200OK);
        }

        public Task<ResponseDTO<NoContent>> UpdateAsync(CategoryUpdateDTO categoryUpdateDTO)
        {
            throw new NotImplementedException();
        }
    }

}
