using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ND.AR.Project.BL.Interfaces;
using ND.AR.Project.DA.Services;

namespace ND.AR.Project.API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        public readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string email)
        {
            return Ok(await _userService.GetUserAsync(email));
        }
    }
}
