using DatingApp.API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IDatingRepository _repo;

        public UsersController(IDatingRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _repo.GetUsers();

            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = _repo.GetUser(id);

            return Ok(user);
        }
    }
}