using ITSAIntermediate_OmphileMojahi_.Data;
using ITSAIntermediate_OmphileMojahi_.Services;

namespace Test
{
    public class UserServiceTests
    {
        private readonly UserService _service;
        private IUserDataStore _userDataStore;

        public UserServiceTests()
        {
            _service = new UserService(_userDataStore);
        }

        [Fact]
        public async Task GetUserAsync()
        {
            // given filters
            var userId = new Guid("FF2E4EC2-3EF9-484B-8065-CCF30778FAE8");

            // when - getting the user
            var result = await _service.GetUserAsync(userId);
            // then - expect not empty/null
            Assert.NotNull(result);
        }

        [Fact]
        public void GetUsersAsync()
        {
            var results = _service.GetUsersAsync();
            // then - expect not empty/null
            Assert.NotEmpty((System.Collections.IEnumerable)results);
        }
    }
}