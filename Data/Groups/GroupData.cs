using MealPlanningAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MealPlanningAPI.Data.Groups
{
    public class GroupData : IGroupData
    {
        MealPlanningDbContext _context;

        public GroupData (MealPlanningDbContext context)
        {
            _context = context;
        }

        public void AddGroup(Group group)
        {
            _context.groups.Add(group);
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void DeleteGroup(int id)
        {
            var group = GetGroupById(id);
            if (group != null)
            {
                _context.groups.Remove(group);
            }
        }

        public List<Group> GetAllGroups()
        {
            return _context.groups.ToList();
        }

        public Group GetGroupById(int id)
        {
            return _context.groups.Find(id);
        }

        public void UpdateGroup(Group group)
        {
            DeleteGroup(group.GroupID);
            AddGroup(group);
        }
    }
}
