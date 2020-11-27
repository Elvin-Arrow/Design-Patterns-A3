using System.Collections.Generic;

namespace Design_Pattern_Assignment_3.Data
{
    public class Meal
    {
        private List<Item> _items = new List<Item>();

        public void addItem(Item item) { 
            _items.Add(item);
        }

        public float getCost()
        {
            float cost = 0.0F;

            foreach (var item in _items)
            {
                cost += item.price();
            }

            return cost;
        }

        public void showItems()
        {
            foreach (var item in _items)
            {
                System.Console.WriteLine("Item name: " + item.name() + "\nPacking: " + item.packing() + "\nPrice: " + item.price());
            }
        }

        public List<Item> getMealItems() { return _items; }

        public int itemCount() {
            return _items.Count;
        }

    }
}