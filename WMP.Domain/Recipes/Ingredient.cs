namespace WMP.Domain.Recipes;

public class Ingredient {
    public string Name { get; }

    public double? Weight { get; }

    public Ingredient(string name, double? weight) =>
        (Name, Weight) = (name, weight);
    
    private Ingredient() { }
}