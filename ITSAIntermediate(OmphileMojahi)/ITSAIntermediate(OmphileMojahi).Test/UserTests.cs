using ITSAIntermediate_OmphileMojahi_.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ITSAIntermediate_OmphileMojahi_.Test
{
    public class UserTests
    {
        private readonly UserService _userService;

        [Fact]
        public async Task GetUserAsync()
        {
            // given filters
            var userId = new Guid("A57C2509-A797-48F7-91B7-AD3C7AB5BF6F");

            // when - getting the bookings
            var result = await _userService.GetUserAsync(userId);

            // then - expect not empty/null
            Assert.NotNull(result);
        }
    }
}
