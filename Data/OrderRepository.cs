using System.Collections.Generic;

namespace Design_Pattern_Assignment_3.Data
{
    public enum FoodItems
    {
        Lentil,
        FalafilPatty,
        GrilledChicken,
        MushroomChicken,
        Combo1,
        Combo2,
    }

    public enum Drinks
    {
        Coke,
        Pepsi,
    }



    public class Order
    {
        private MealBuilder _mealBuilder { get; set; }
        private Meal _meal { get; set; }

        public Order()
        {
            _mealBuilder = new MealBuilder();
        }
        public int calculateQuantity(List<Item> items, Item requiredQuantityItem)
        {
            int quantity = 0;
            foreach (var item in items)
            {
                if (item.name() == requiredQuantityItem.name()) quantity++;
            }

            return quantity;
        }

        public Meal addItem(FoodItems type)
        {

            switch (type)
            {
                case FoodItems.Lentil:
                    _meal = _mealBuilder.prepareVegMeal("Lentil Burger", 250.0F);
                    break;

                case FoodItems.FalafilPatty:
                    _meal = _mealBuilder.prepareVegMeal("Falafil patty burger", 350.0F);
                    break;


                case FoodItems.GrilledChicken:
                    _meal = _mealBuilder.prepareNonVegMeal("Grilled Chicken burger", 400.0F);
                    break;


                case FoodItems.MushroomChicken:
                    _meal = _mealBuilder.prepareNonVegMeal("Mushroom Chicken burger", 450.0F);
                    break;

                case FoodItems.Combo1:
                    _meal = _mealBuilder.prepareCombo(type, "Lentil Burger", 350.0F, Drinks.Coke, 90.0F);
                    break;

                case FoodItems.Combo2:
                    _meal = _mealBuilder.prepareCombo(type, "Grilled Chicken Burger", 400.0F, Drinks.Pepsi, 85.0F);
                    break;

                default:
                    return null;
            }
            return _meal;
        }

    }




}