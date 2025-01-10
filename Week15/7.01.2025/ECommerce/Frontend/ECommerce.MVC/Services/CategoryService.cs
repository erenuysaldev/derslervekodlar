using ECommerce.MVC.Abstract;
using ECommerce.MVC.Models;
using ECommerce.Shared.ResponseDTOs;
using System.Text.Json;

namespace ECommerce.MVC.Services
{
    public class CategoryService : BaseService, ICategoryService
    {
        public CategoryService(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor) : base(httpClientFactory, httpContextAccessor)
        {
        }

        public Task<CategoryModel> AddCategoryAsync(CategoryModel category)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CategoryModel>> GetActiveCategoriesAsync()
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.GetAsync("categories/getall/true");
                response.EnsureSuccessStatusCode();
                var jsonString = await response.Content.ReadAsStringAsync();
                ResponseDTO<IEnumerable<CategoryModel>> result;
                try
                {
                    result = JsonSerializer.Deserialize<ResponseDTO<IEnumerable<CategoryModel>>>(jsonString, _jsonSerializerOptions)
                             ?? throw new JsonException("Deserialization returned null.");
                }
                catch (JsonException ex)
                {
                    Console.WriteLine($"Json Deserialize Error: {ex.Message}");
                    return Enumerable.Empty<CategoryModel>();
                }

                if (result.Errors == null || result.Errors.Count == 0)
                {
                    return result.Data ?? Enumerable.Empty<CategoryModel>();
                }
                else
                {
                    Console.WriteLine($"Request Error: {string.Join(",", result.Errors ?? Enumerable.Empty<string>())}");
                    return Enumerable.Empty<CategoryModel>();
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Http Request Exception: {ex.Message}");
                return Enumerable.Empty<CategoryModel>();
            }
        }

        public Task<CategoryModel> GetActiveCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoryModel>> GetActiveCategoryAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoryModel>> GetCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryModel> GetCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetCategoryCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoryModel>> GetPassiveCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoryModel>> GetPassiveCategoryAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategoryAsync(CategoryModel category)
        {
            throw new NotImplementedException();
        }

        Task ICategoryService.AddCategoryAsync(CategoryModel category)
        {
            throw new NotImplementedException();
        }
    }
}