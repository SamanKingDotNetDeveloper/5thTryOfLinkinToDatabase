using _5thTry.DbContexts;
using _5thTry.Models;
using Microsoft.AspNetCore.Mvc;

namespace _5thTry.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        public UserController(UserDbContext _userDb)
        {
            this.userDb = _userDb;
        }
        private readonly UserDbContext userDb;

        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return userDb.Users;
        }

        [HttpGet]
        public IEnumerable<Car> GetCars()
        {
            return userDb.Cars;
        }
    }
}
