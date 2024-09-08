using CorePulse.API.Models.Domains;

namespace CorePulse.API.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateCategoriesAsync(Category category);    
        Task<List<Category>> GetAllCategoriesAsync();   
        Task<Category> GetCategoryByIdAsync(Guid categoryId);
        Task<Category> DeleteCategoryByIdAsync(Guid categoryId);
    }
}
