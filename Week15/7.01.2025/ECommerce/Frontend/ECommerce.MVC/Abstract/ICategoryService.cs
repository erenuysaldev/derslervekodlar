using ECommerce.MVC.Models;

namespace ECommerce.MVC.Abstract
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryModel>> GetCategoriesAsync();
        Task<IEnumerable<CategoryModel>> GetActiveCategoryAsync();
        Task<IEnumerable<CategoryModel>> GetPassiveCategoryAsync();
        Task<CategoryModel>GetActiveCategoryAsync(int id);
        Task<int> GetCategoryCountAsync();
        Task AddCategoryAsync(CategoryModel category);
        Task UpdateCategoryAsync(CategoryModel category);
        Task DeleteCategoryAsync(int id);




    }
}
