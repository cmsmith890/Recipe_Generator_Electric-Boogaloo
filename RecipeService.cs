using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Recipe_Generator_Electric_Boogaloo
{
    public class RecipeService(AppDbContext context)
    {
        private readonly AppDbContext _context = context;

        public async Task<Recipe?> GenerateRecipeAsync(List<string> availableIngredients)
        {
            var recipes = await _context.Recipes.ToListAsync();
            return recipes.FirstOrDefault(recipe => recipe.Ingredients.All(availableIngredients.Contains));
        }
    }
}
