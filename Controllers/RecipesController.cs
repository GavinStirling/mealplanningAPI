using MealPlanningAPI.Data.Households;
using MealPlanningAPI.Data.Recipes;
using MealPlanningAPI.Data.Users;
using MealPlanningAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MealPlanningAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly IRecipeData recipeData;

        public RecipesController(IRecipeData recipeData)
        {
            this.recipeData = recipeData;
        }

        // GET: api/Recipes
        [HttpGet]
        public JsonResult GetAllRecipes()
        {
            var results = recipeData.GetAllRecipes();
            if (results == null)
            {
                return new JsonResult(NotFound());
            }
            return new JsonResult(Ok(results));
        }

        // GET: api/Recipes/{id}
        [HttpGet("{id}")]
        public JsonResult GetRecipeById(int id)
        {
            var results = recipeData.GetRecipeById(id);
            if (results == null)
            {
                return new JsonResult(NotFound());
            }
            return new JsonResult(Ok(results));
        }

        // PUT: api/Recipes
        [HttpPut]
        public JsonResult UpdateRecipe(Recipe recipe)
        {
            var existingRecipe = recipeData.GetRecipeById(recipe.RecipeID);
            if (existingRecipe == null)
            {
                return new JsonResult(NotFound());
            }
            recipeData.UpdateRecipe(recipe);
            recipeData.Commit();
            return new JsonResult(Ok(recipe));
        }

        // POST: api/Recipes
        [HttpPost]
        public JsonResult CreateRecipe(Recipe recipe)
        {
            recipeData.AddRecipe(recipe);
            recipeData.Commit();
            return new JsonResult(Ok(recipe));
        }

        // DELETE: api/Recipes
        [HttpDelete("{id}")]
        public JsonResult DeleteRecipe(int id)
        {
            var recipe = recipeData.GetRecipeById(id);
            if (recipe == null)
            {
                return new JsonResult(NotFound());
            }
            recipeData.DeleteRecipe(id);
            recipeData.Commit();
            return new JsonResult(Ok(recipe));
        }
    }
}
