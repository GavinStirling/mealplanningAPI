using MealPlanningAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MealPlanningAPI.Data.Households
{
    public class HouseholdData : IHouseholdData
    {
        MealPlanningDbContext _context;

        public HouseholdData(MealPlanningDbContext context)
        {
            _context = context;
        }

        public void AddHousehold(Household household)
        {
            _context.houses.Add(household);
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void DeleteHousehold(int id)
        {
            var household = GetHouseholdById(id);
            if (household != null)
            {
                _context.houses.Remove(household);
            }
        }

        public List<Household> GetAllHouseholds()
        {
            return _context.houses.ToList();
        }

        public Household GetHouseholdById(int id)
        {
            return _context.houses.Find(id);
        }

        public void UpdateHousehold(Household household)
        {
            DeleteHousehold(household.HouseholdId);
            AddHousehold(household);
        }
    }
}
