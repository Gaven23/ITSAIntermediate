using ITSAIntermediate_OmphileMojahi_.Data;
using ITSAIntermediate_OmphileMojahi_.Data.Models;
using ITSAIntermediate_OmphileMojahi_.Services;
using Microsoft.AspNetCore.Mvc;

namespace ITSAIntermediate_OmphileMojahi_.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserDataStore _userDataStore;
        public UsersController(IUserDataStore dataStore)
        {
            _userDataStore = dataStore;
        }
        public IActionResult Index()
        {
            //Get List Of Users
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetUser(Guid userId)
        {


            return Ok();
        }

        /// <summary>
        /// Create User.
        /// </summary>
        /// 
        [HttpPost]
        public async Task<IActionResult> Create(Users user)
        {
            {
                if (user is null)
                    return BadRequest(new ProblemDetails { Detail = "user required." });
                var service = new UserService(_userDataStore);
                await service.CreateUserAsync(user);

                return Ok(user);
            }
        }
    }
}