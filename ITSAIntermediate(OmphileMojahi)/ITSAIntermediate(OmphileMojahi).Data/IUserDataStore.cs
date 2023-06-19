using ITSAIntermediate_OmphileMojahi_.Data.Models;

namespace ITSAIntermediate_OmphileMojahi_.Data
{
    public interface IUserDataStore 
    {
        Task<IEnumerable<Users>> GetUsersAsync();
        Task CreateUserAsync(Users user);
        Task<Users> GetUserAsync(Guid userId);
    }
}