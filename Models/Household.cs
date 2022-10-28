namespace MealPlanningAPI.Models
{
    public class Household
    {
        public int HouseholdId { get; set; }
        public string HouseholdName { get; set; }

        public Household (int householdId, string householdName)
        {
            HouseholdId = householdId;
            HouseholdName = householdName;
        }
    }
}
