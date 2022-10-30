using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MealPlanningAPI.Models
{
    [Table("Recipes")]
    public class Recipe
    {
        [Required]
        [Key]
        [Column("RecipeID")]
        public int RecipeID { get; set; }
        public string RecipeName { get; set; }
        public string Difficulty { get; set; }
        public int PrepTime { get; set; }
        
        public Recipe (int recipeID, string recipeName, string difficulty, int prepTime)
        {
            RecipeID = recipeID;
            RecipeName = recipeName;
            Difficulty = difficulty;
            PrepTime = prepTime;
        }
    }
}
