using WMP.Domain.Foods.Enum;
using WMP.Domain.Recipes;

namespace WMP.Domain.Foods; 

public class Food {
    public FoodType FoodType { get; private set; }

    public Recipe Recipe { get; private set; }

    public Food(FoodType foodType, Recipe recipe) {
        FoodType = foodType;
        Recipe = recipe;
    }

    private Food() { }

    public void UpdateFoodType(FoodType newFodType) =>
        FoodType = newFodType;
}