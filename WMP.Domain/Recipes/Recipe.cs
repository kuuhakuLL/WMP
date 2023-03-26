namespace WMP.Domain.Recipes; 

public class Recipe {
    public string? Description { get; private set; }

    public IEnumerable<Ingredient> Ingredients => _ingredients.AsEnumerable();

    private ICollection<Ingredient> _ingredients;

    public Recipe(string? description, ICollection<Ingredient> ingredients) {
        Description = description;
        _ingredients = ingredients;
    }
    
    private Recipe() { }

    public void UpdateDescription(string? newDescription) {
        Description = newDescription;
    }

    public void AddIngredient(Ingredient newIngredient) {
        _ingredients.Add(newIngredient);
    }
    
    public void AddIngredients(IEnumerable<Ingredient> newIngredients) {
        foreach (var ingredient in newIngredients) {
            AddIngredient(ingredient);
        }
    }
}