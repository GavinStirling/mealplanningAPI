using MealPlanningAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MealPlanningAPI.Data.Recipes
{
    public class RecipeData : IRecipeData
    {
        MealPlanningDbContext _context;

        public RecipeData(MealPlanningDbContext context)
        {
            _context = context;
        }

        public void AddRecipe(Recipe recipe)
        {
            _context.recipes.Add(recipe);
        }

        public int Commit()
        {
           return _context.SaveChanges();
        }

        public void DeleteRecipe(int id)
        {
            var recipe = GetRecipeById(id);
            if (recipe != null)
            {
                _context.recipes.Remove(recipe);
            }
        }

        public List<Recipe> GetAllRecipes()
        {
            return _context.recipes.ToList();
        }

        public Recipe GetRecipeById(int id)
        {
            return _context.recipes.Find(id);
        }

        public void UpdateRecipe(Recipe recipe)
        {
            DeleteRecipe(recipe.RecipeID);
            AddRecipe(recipe);    
        }
    }
}
