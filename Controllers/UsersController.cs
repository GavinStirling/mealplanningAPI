using MealPlanningAPI.Services.Users;
using Microsoft.AspNetCore.Mvc;

namespace MealPlanningAPI.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View(_userService.getAll());
        }
    }
}
