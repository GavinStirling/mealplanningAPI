namespace MealPlanningAPI.Models
{
    public class Recipe
    {
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
