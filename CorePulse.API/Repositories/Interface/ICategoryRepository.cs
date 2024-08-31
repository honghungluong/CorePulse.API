using CorePulse.API.Models.Domains;

namespace CorePulse.API.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateCategoriesAsync(Category category);    
    }
}
