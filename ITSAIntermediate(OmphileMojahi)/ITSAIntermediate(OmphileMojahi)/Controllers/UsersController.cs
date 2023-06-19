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
        /// <summary>
        /// Get list of user's.
        /// </summary>
        /// 
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var service = new UserService(_userDataStore);

            var result = await service.GetUsersAsync();

            return View(result);
        }
        /// <summary>
        /// Get user details.
        /// </summary>
        /// 

        [Route("/Users/ViewUserDetailsAsync/{userId}")]
        [HttpGet]
        public async Task<IActionResult> ViewUserDetailsAsync(Guid userId)
        {
            var service = new UserService(_userDataStore);

            var result = await service.GetUserAsync(userId);

            return View(result);
        }

        /// <summary>
        /// Create User.
        /// </summary>
        /// 
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Users user)
        {
            if (ModelState.IsValid)
            {
                if (user is null)
                    return BadRequest(new ProblemDetails { Detail = "user required." });
                var service = new UserService(_userDataStore);
                user.UserId = Guid.NewGuid();
                await service.CreateUserAsync(user);
                return RedirectToAction(nameof(Index)); 
            }

            return View(user);
        }
    }
}