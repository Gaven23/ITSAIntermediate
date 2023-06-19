using ITSAIntermediate_OmphileMojahi_.Data;
using ITSAIntermediate_OmphileMojahi_.Data.Models;

namespace ITSAIntermediate_OmphileMojahi_.Services
{
    public class UserService
    {
        private readonly IUserDataStore _userDataStore;

        public UserService(IUserDataStore dataStore)
        {
            _userDataStore = dataStore;
        }

        public async Task CreateUserAsync(Users user)
        {
            if (user is not null)
                await _userDataStore.CreateUserAsync(user);
            else
                throw new InvalidOperationException("");
        }

        public async Task<Users> GetUserAsync(Users user)
        {
                throw new InvalidOperationException("");
        }
    }
}
