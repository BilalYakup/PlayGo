using PlayGo.Infrastructure.Context;
using PlayGo.Infrastructure.Repositories.Interfaces;
using PlayGo.Models.Concrete;
using Microsoft.EntityFrameworkCore;
using PlayGo.Infrastructure.Repositories.Concrete;

namespace PlayGo.Infrastructure.Repositories.Concrete
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<bool> AnyCategoryName(string name)
        {
            return await _context.Categories.Where(x => x.Status != Models.Abstract.Status.Passive).AnyAsync(x => x.Name == name);
        }
    }
}
