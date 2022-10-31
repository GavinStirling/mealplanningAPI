using MealPlanningAPI.Data.Households;
using MealPlanningAPI.Data.Recipes;
using MealPlanningAPI.Data.Users;
using MealPlanningAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MealPlanningAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseholdsController : ControllerBase
    {
        private readonly IHouseholdData householdData;

        public HouseholdsController(IHouseholdData householdData)
        {
            this.householdData = householdData;
        }

        // GET: api/Households
        [HttpGet]
        public JsonResult GetAllHouseholds()
        {
            var results = householdData.GetAllHouseholds();
            if (results == null)
            {
                return new JsonResult(NotFound());
            }
            return new JsonResult(Ok(results));
        }

        // GET: api/Households/{id}
        [HttpGet("{id}")]
        public JsonResult GetHouseholdById(int id)
        {
            var results = householdData.GetHouseholdById(id);
            if (results == null)
            {
                return new JsonResult(NotFound());
            }
            return new JsonResult(Ok(results));
        }

        // POST: api/Households
        [HttpPost]
        public JsonResult CreateUpdateHousehold(Household household)
        {
            var existingHousehold = householdData.GetHouseholdById(household.HouseholdId);  
            if (existingHousehold == null)
            {
                householdData.AddHousehold(household);
            }
            else
            {
                householdData.UpdateHousehold(household);
            }
            householdData.Commit();
            return new JsonResult(Ok(household));
        }

        // DELETE: api/Households
        [HttpDelete("{id}")]
        public JsonResult DeleteHousehold(int id)
        {
            var household = householdData.GetHouseholdById(id);
            if (household == null)
            {
                return new JsonResult(NotFound());
            }
            householdData.DeleteHousehold(id);
            householdData.Commit();
            return new JsonResult(Ok(household));
        }
    }
}
