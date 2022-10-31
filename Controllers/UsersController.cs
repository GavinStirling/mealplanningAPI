using MealPlanningAPI.Data.Users;
using MealPlanningAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MealPlanningAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserData userData;

        public UsersController(IUserData userData)
        {
            this.userData = userData;
        }

        // GET: api/Users
        [HttpGet]
        public JsonResult GetAllUsers()
        {
            var results = userData.GetAllUsers();
            if (results == null)
            {
                return new JsonResult(NotFound());
            }
            return new JsonResult(Ok(results));
        }

        // GET: api/Users/{id}
        [HttpGet("{id}")]
        public JsonResult GetUserById(int id)
        {
            var results = userData.GetUserById(id);
            if (results == null)
            {
                return new JsonResult(NotFound());
            }
            return new JsonResult(Ok(results));
        }

        // POST: api/Users
        [HttpPost]
        public JsonResult CreateUpdateUser(User user)
        {
            if (user.UserID == 0)
            {
                userData.AddUser(user);
            }
            else
            {
                var existingUser = userData.GetUserById(user.UserID);
                if (existingUser == null)
                {
                    return new JsonResult(NotFound());
                }
                userData.UpdateUser(user);
            }
            userData.Commit();
            return new JsonResult(Ok(user));
        }

        // DELETE: api/Users
        [HttpDelete("{id}")]
        public JsonResult DeleteUser(int id)
        {
            var user = userData.GetUserById(id);
            if (user == null)
            {
                return new JsonResult(NotFound());
            }
            userData.DeleteUser(id);
            userData.Commit();
            return new JsonResult(Ok(user));
        }
    }
}
