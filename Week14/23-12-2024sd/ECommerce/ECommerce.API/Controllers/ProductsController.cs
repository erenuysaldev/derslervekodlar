﻿using ECommerce.Business.Abstract;
using ECommerce.Shared.DTOs;
using ECommerce.Shared.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : CustomControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductCreateDTO productCreateDTO)
        {
            var response = await _productService.AddAsync(productCreateDTO);
            return CreateResponse(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _productService.GetAllAsync();
            return CreateResponse(response);
        }

        [HttpGet("{isActive}")]
        public async Task<IActionResult> GetAll(bool isActive)
        {
            var response = await _productService.GetAllAsync(isActive);
            return CreateResponse(response);
        }

        [HttpGet("withcategories")]
        public async Task<IActionResult> GetAllWithCategories()
        {
            var response = await _productService.GetAllWithCategoriesAsync();
            return CreateResponse(response);
        }

        [HttpGet("bycategory/{categoryId}")]
        public async Task<IActionResult> GetAllByCategory(int categoryId)
        {
            var response = await _productService.GetByCategoryAsync(categoryId);
            return CreateResponse(response);
        }

        [HttpGet("get/{id}")] //http://localhost:5050/api/products/get/4
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _productService.GetAsync(id);
            return CreateResponse(response);
        }

        [HttpGet("getwithcategories/{id}")] 
        public async Task<IActionResult> GetByIdWithCategories(int id)
        {
            var response = await _productService.GetWithCategoriesAsync(id);
            return CreateResponse(response);
        }

        [HttpGet("count")]
        public async Task<IActionResult> GetCount()
        {
            var response = await _productService.GetCountAsync();
            return CreateResponse(response);
        }

        [HttpGet("count/{isActive}")]
        public async Task<IActionResult> GetCount(bool isActive)
        {
            var response = await _productService.GetCountAsync(isActive);
            return CreateResponse(response);
        }

        [HttpGet("countbycategory/{categoryId}")]
        public async Task<IActionResult> GetCount(int categoryId)
        {
            var response = await _productService.GetCountByCategory(categoryId);
            return CreateResponse(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(ProductUpdateDTO productUpdateDTO)
        {
            var response = await _productService.UpdateAsync(productUpdateDTO);
            return CreateResponse(response);
        }

        [HttpGet("updateisactive/{id}")]
        public async Task<IActionResult> UpdateIsActive(int id)
        {
            var response = await _productService.UpdateIsActiveAsync(id);
            return CreateResponse(response);
        }

    }
}
