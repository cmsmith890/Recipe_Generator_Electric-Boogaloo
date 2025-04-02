using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Recipe_Generator_Electric_Boogaloo
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Recipe> Recipes { get; set; }

        //  protected override void OnModelCreating(ModelBuilder modelBuilder) //Remove - Handled by DataAnnotations
        //  {
        //      // Configure the relationship between Recipe and Ingredients
        //      modelBuilder.Entity<Recipe>()
        //          .HasMany(r => r.Ingredients)
        //          .WithOne()
        //          .HasForeignKey(i => i.RecipeId);
        //
        //      // Seed data (optional, for initial setup)
        //      modelBuilder.Entity<Recipe>().HasData(
        //          new Recipe
        //          {
        //              Id = 1,
        //              Name = "Simple Tomato Pasta",
        //              Instructions = "Cook pasta according to package directions. Sauté garlic in olive oil, add tomatoes and simmer. Toss with pasta and basil."
        //          },
        //          new Recipe
        //          {
        //              Id = 2,
        //              Name = "Quick Scrambled Eggs",
        //              Instructions = "Whisk eggs and milk. Melt butter in a pan. Pour in egg mixture and cook, stirring occasionally, until set. Season with salt and pepper."
        //          },
        //           new Recipe
        //          {
        //              Id = 3,
        //              Name = "Peanut Butter Sandwich",
        //              Instructions = "Spread peanut butter on one slice of bread. Add jelly to the other slice if desired. Put the slices together."
        //          }
        //      );
        //
        //       modelBuilder.Entity<Ingredient>().HasData(
        //           new Ingredient { Id = 1, RecipeId = 1, Name = "Pasta" },
        //           new Ingredient { Id = 2, RecipeId = 1, Name = "Canned Tomatoes" },
        //           new Ingredient { Id = 3, RecipeId = 1, Name = "Garlic" },
        //           new Ingredient { Id = 4, RecipeId = 1, Name = "Olive Oil" },
        //           new Ingredient { Id = 5, RecipeId = 1, Name = "Basil" },
        //           new Ingredient { Id = 6, RecipeId = 2, Name = "Eggs" },
        //           new Ingredient { Id = 7, RecipeId = 2, Name = "Milk" },
        //           new Ingredient { Id = 8, RecipeId = 2, Name = "Butter" },
        //           new Ingredient { Id = 9, RecipeId = 2, Name = "Salt" },
        //           new Ingredient { Id = 10, RecipeId = 2, Name = "Pepper" },
        //           new Ingredient {Id = 11, RecipeId = 3, Name = "Bread"},
        //           new Ingredient {Id = 12, RecipeId = 3, Name = "Peanut Butter"},
        //           new Ingredient {Id = 13, RecipeId = 3, Name = "Jelly (optional)"}
        //       );
        //  }
    }
}
