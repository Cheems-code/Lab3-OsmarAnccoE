using Lab3_OsmarAnccoE.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab3_OsmarAnccoE.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(LocalContext context) : base(context)
        {
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            return await _context.Users
                .FirstOrDefaultAsync(user => user.Email == email);
        }
    }
}