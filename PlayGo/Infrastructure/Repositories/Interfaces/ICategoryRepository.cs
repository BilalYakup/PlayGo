using PlayGo.Models.Concrete;

namespace PlayGo.Infrastructure.Repositories.Interfaces
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        Task<bool> AnyCategoryName(string name);
    }
}
