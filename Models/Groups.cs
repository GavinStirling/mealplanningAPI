namespace MealPlanningAPI.Models
{
    public class Groups
    {
        public int GroupID { get; set; }
        public int HouseholdID { get; set; }
        public int AdminID { get; set; }
        public string? Members { get; set; }
        public List<int>? MemberIDs { get; set; }

        public Groups (int groupID, int householdID, int adminID)
        {
            GroupID = groupID;
            HouseholdID = householdID;
            AdminID = adminID;
        }

        public Groups(int groupID, int householdID, int adminID, string members) : this(groupID, householdID, adminID)
        {
            Members = members;
            MemberIDs = new List<int>();
            string[] memberIDs = members.Split(",");
            foreach(var member in memberIDs)
            {
                MemberIDs.Add(Int16.Parse(member));
            }
        }
    }
}
