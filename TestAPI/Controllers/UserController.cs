using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestAPI.Data;

namespace TestAPI.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        public IRepository Repository { get; set; }
        public UserController(IRepository repository) 
        {
            Repository = repository;
        }

        // GET: UserController
        [HttpGet("users")]
        public IEnumerable<User> Users()
        {
            return Repository.AllUsers();
        }

        // GET: UserController/Details/5
        [HttpGet("user/{id}")]
        public new User User(string id)
        {
            return Repository.GetById(id);
        }

        // POST: UserController/Create
        [HttpPost("user")]
        public ActionResult Create(User user)
        {
            Repository.CreateUser(user);
            return Ok();
        }
        
    }
}
