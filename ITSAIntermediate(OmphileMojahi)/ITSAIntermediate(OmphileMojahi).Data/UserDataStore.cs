using ITSAIntermediate_OmphileMojahi_.Data.Models;

namespace ITSAIntermediate_OmphileMojahi_.Data
{
    public partial class UserDataStore : IUserDataStore
    {
        private readonly ApplicationDbContext _context;

        public UserDataStore(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateUserAsync(Users user)
        {
            await _context.Users.AddRangeAsync(user);
            await _context.SaveChangesAsync();
        }

        public Task<Users> GetUserAsync(Guid UserId)
        {
            throw new NotImplementedException();
        }
    }
}
