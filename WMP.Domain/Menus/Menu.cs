using WMP.Domain.Foods;

namespace WMP.Domain.Menus; 

public class Menu {
    public Food Food { get; }
    
    public DateTime DateTime { get; }

    public Menu(Food food, DateTime dateTime) {
        Food = food;
        DateTime = dateTime;
    }

    private Menu() {}
}