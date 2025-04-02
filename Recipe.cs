using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recipe_Generator_Electric_Boogaloo
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public string? Instructions { get; set; }

        // Navigation property for the relationship
        public List<string> Ingredients { get; set; } = [];
    }
}
