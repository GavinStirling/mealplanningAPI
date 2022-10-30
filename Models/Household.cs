using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MealPlanningAPI.Models
{
    [Table("Households")]
    public class Household
    {
        [Required]
        [Key]
        [Column("HouseholdID")]
        public int HouseholdId { get; set; }
        public string Name { get; set; }

        public Household (int householdId, string name)
        {
            HouseholdId = householdId;
            Name = name;
        }
    }
}
