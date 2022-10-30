using MealPlanningAPI.Models;

namespace MealPlanningAPI.Data.Recipes
{
    public interface IRecipeData
    {
        List<Recipe> GetAllRecipes();
        Recipe GetRecipeById(int id);
        void AddRecipe(Recipe recipe);
        void UpdateRecipe(Recipe recipe);
        void DeleteRecipe(int id);
        int Commit();
    }
}
