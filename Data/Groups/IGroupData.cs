using MealPlanningAPI.Models;

namespace MealPlanningAPI.Data.Groups
{
    public interface IGroupData
    {
        List<Group> GetAllGroups();
        Group GetGroupById(int id);
        void AddGroup(Group group);
        void UpdateGroup(Group group);
        void DeleteGroup(int id);
        int Commit();
    }
}
