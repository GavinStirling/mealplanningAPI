using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MealPlanningAPI.Models
{
    [Table("Groups")]
    public class Group
    {
        [Required]
        [Key]
        [Column("GroupID")]
        public int GroupID { get; set; }
        [ForeignKey("HouseholdID")]
        public int HouseholdID { get; set; }
        [ForeignKey("AdminID")]
        public int AdminID { get; set; }
        public string? Members { get; set; } = "";

        public Group (int groupID, int householdID, int adminID, string members)
        {
            GroupID = groupID;
            HouseholdID = householdID;
            AdminID = adminID;
            Members = members;
        }
    }
}
