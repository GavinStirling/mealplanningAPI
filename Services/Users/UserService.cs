using MealPlanningAPI.Data;
using MealPlanningAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MealPlanningAPI.Services.Users
{
    public class UserService : IUserService
    {
        UserDbContext _dbContext;

        public UserService(UserDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<User> getAll()
        {
            if (_dbContext.users.ToList() != null)
            {
                return _dbContext.users.ToList();
            }
            return  new List<User>();
        }
    }
}
