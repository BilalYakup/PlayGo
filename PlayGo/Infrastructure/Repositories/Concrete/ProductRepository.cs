using PlayGo.Infrastructure.Context;
using PlayGo.Infrastructure.Repositories.Interfaces;
using PlayGo.Models.Concrete;
using PlayGo.Infrastructure.Repositories.Concrete;

namespace PlayGo.Infrastructure.Repositories.Concrete
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

      
    }
}
