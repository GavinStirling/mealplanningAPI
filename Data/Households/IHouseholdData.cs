using MealPlanningAPI.Models;

namespace MealPlanningAPI.Data.Households
{
    public interface IHouseholdData
    {
        List<Household> GetAllHouseholds();
        Household GetHouseholdById(int id);
        void AddHousehold(Household household);
        void UpdateHousehold(Household household);
        void DeleteHousehold(int id);
        int Commit();
    }
}
