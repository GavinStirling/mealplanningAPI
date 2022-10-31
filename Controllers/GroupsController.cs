using MealPlanningAPI.Data.Groups;
using MealPlanningAPI.Data.Recipes;
using MealPlanningAPI.Data.Users;
using MealPlanningAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MealPlanningAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly IGroupData groupData;

        public GroupsController(IGroupData groupData)
        {
            this.groupData = groupData;
        }

        // GET: api/Groups
        [HttpGet]
        public JsonResult GetAllGroups()
        {
            var results = groupData.GetAllGroups();
            if (results == null)
            {
                return new JsonResult(NotFound());
            }
            return new JsonResult(Ok(results));
        }

        // GET: api/Groups/{id}
        [HttpGet("{id}")]
        public JsonResult GetGroupById(int id)
        {
            var results = groupData.GetGroupById(id);
            if (results == null)
            {
                return new JsonResult(NotFound());
            }
            return new JsonResult(Ok(results));
        }

        // POST: api/Groups
        [HttpPost]
        public JsonResult CreateUpdateGroup(Group group)
        {
            var existingUser = groupData.GetGroupById(group.GroupID);
            if (existingUser == null)
            {
                groupData.AddGroup(group);
            }
            else
            {
                groupData.UpdateGroup(group);
            }
            groupData.Commit();
            return new JsonResult(Ok(group));
        }

        // DELETE: api/Groups
        [HttpDelete("{id}")]
        public JsonResult DeleteGroup(int id)
        {
            var group = groupData.GetGroupById(id);
            if (group == null)
            {
                return new JsonResult(NotFound());
            }
            groupData.DeleteGroup(id);
            groupData.Commit();
            return new JsonResult(Ok(group));
        }
    }
}
