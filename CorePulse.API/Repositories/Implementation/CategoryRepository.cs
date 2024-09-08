using CorePulse.API.Data;
using CorePulse.API.Models.Domains;
using CorePulse.API.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace CorePulse.API.Repositories.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoryRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Category> CreateCategoriesAsync(Category category)
        {
            _dbContext.Categories.Add(category);
            await _dbContext.SaveChangesAsync();
            return category;
        }

        public async Task<Category> DeleteCategoryByIdAsync(Guid categoryId)
        {
            var category = await _dbContext.Categories.FindAsync(categoryId);
            if (category == null)
                return null;

            _dbContext.Categories.Remove(category);
            await _dbContext.SaveChangesAsync();    
            return category;
        }

        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return await _dbContext.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(Guid id)    
        {
            var category = await _dbContext.Categories.FindAsync(id);
            return category;
        }
    }
}
