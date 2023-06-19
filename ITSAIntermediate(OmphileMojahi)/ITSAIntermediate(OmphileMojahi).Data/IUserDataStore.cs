using System.Collections.Generic;
using System.Threading.Tasks;

using ITSAIntermediate_OmphileMojahi_.Data.Models;

namespace ITSAIntermediate_OmphileMojahi_.Data
{
    public interface IUserDataStore 
    {
        Task CreateUserAsync(Users user);
        Task<Users> GetUserAsync(Guid UserId);
    }
}
