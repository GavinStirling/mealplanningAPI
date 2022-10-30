using MealPlanningAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MealPlanningAPI.Data.Users
{
    public class UserData : IUserData
    {
        MealPlanningDbContext _context;

        public UserData(MealPlanningDbContext context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            _context.users.Add(user);
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var user = GetUserById(id);
            if (user != null)
            {
                _context.users.Remove(user);
            }
        }

        public List<User> GetAllUsers()
        {
            return _context.users.ToList();
        }

        public User GetUserById(int id)
        {
            return _context.users.Find(id);
        }

        public void UpdateUser(User user)
        {
            var entity = _context.users.Attach(user);
            entity.State = EntityState.Modified;
        }
    }
}
