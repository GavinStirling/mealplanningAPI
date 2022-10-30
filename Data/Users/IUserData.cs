using MealPlanningAPI.Models;

namespace MealPlanningAPI.Data.Users
{
    public interface IUserData
    {
        List<User> GetAllUsers();
        User GetUserById(int id);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
        int Commit();
    }
}
