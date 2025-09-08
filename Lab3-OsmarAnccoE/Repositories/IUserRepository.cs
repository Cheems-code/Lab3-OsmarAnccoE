using Lab3_OsmarAnccoE.Models;

namespace Lab3_OsmarAnccoE.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User?> GetByEmailAsync(string email);
    }
}