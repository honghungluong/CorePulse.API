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
    }
}
