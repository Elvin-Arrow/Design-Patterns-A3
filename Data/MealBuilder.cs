namespace Design_Pattern_Assignment_3.Data
{
    public class MealBuilder
    {
        private Meal _meal { get; set; }


        public MealBuilder()
        {
            _meal = new Meal();
        }

        public Meal prepareVegMeal(string name, float price)
        {
            _meal.addItem(new VegetableBurger(name, price));
            return _meal;
        }

        public Meal prepareNonVegMeal(string name, float price)
        {
            _meal.addItem(new ChickenBurger(name, price));
            return _meal;
        }

        public Meal prepareCombo(FoodItems combo, string burgerName, float price, Drinks drink, float drinkPrice)
        {
            switch (combo)
            {
                case FoodItems.Combo1:
                    _meal.addItem(new VegetableBurger(burgerName, price));
                    _meal.addItem(drink == Drinks.Coke ? new Coke(drinkPrice) : new Pepsi(drinkPrice));
                    break;

                case FoodItems.Combo2:
                    _meal.addItem(new ChickenBurger(burgerName, price));
                    _meal.addItem(drink == Drinks.Coke ? new Coke(drinkPrice) : new Pepsi(drinkPrice));
                    break;
                default:
                    return null;
            }
            return _meal;
        }
    }
}