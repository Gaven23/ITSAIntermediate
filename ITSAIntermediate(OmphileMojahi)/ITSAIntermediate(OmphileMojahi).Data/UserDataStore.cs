using ITSAIntermediate_OmphileMojahi_.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ITSAIntermediate_OmphileMojahi_.Data
{
    public partial class UserDataStore : IUserDataStore
    {
        private readonly ApplicationDbContext _context;

        public UserDataStore(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Users>> GetUsersAsync()
        {
            var query = _context.Users.AsNoTracking();

            return await query.ToListAsync();
        }

        public async Task CreateUserAsync(Users user)
        {
            if (user is null)
                throw new Exception($"user is details are null");

            user.Address.UserId = user.UserId;
            user.Employee.UserId = user.UserId;
            user.Company.UserId = user.UserId;
            await _context.Users.AddRangeAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task<Users> GetUserAsync(Guid userId)
        {
            var result = await _context.Users
                        .Include(b => b.Address)
                        .Include(o => o.Employee)
                        .Include(o => o.Company).AsNoTracking().SingleOrDefaultAsync(e => e.UserId == userId);

            return result ?? new();
        }
    }
}
