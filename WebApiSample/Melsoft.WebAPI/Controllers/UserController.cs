using Melsoft.Interfaces.Services;
using Melsoft.Models;
using Microsoft.AspNetCore.Mvc;

namespace Melsoft.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(ServiceResponse<User>), 200)]
        public IActionResult CreateUser([FromBody] User user)
        {
            var response = userService.CreateUser(user);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }
    }
}