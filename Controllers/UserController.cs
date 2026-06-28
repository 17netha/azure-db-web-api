using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace azure_db_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
         public UserController(AppDbContext context)
        {
            _dbContext = context;
        }

        [HttpGet]
        public  ActionResult<List<User>>  GetUsers()
        {
             var users =   _dbContext.Users.ToList();
            return Ok(users);
        }

        [HttpGet("{id:int}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = _dbContext.Users.Find(id);
            if(user is not null)
            {
                return Ok(user);
            }
            return NotFound();
            
        }


    }
}
