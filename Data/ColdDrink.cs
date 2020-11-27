namespace Design_Pattern_Assignment_3.Data
{
    public class Bottle : Packing
    {
        public string pack()
        {
            return "Bottle";
        }
    }

    public abstract class ColdDrink : Item
    {
        private Bottle _bottlePacking { get; set; }
        private string _name { get; set; }
        public string Name => _name;
        private float _price { get; set; }
        public float Price => _price;

        public ColdDrink(string name, float price)
        {
            _bottlePacking = new Bottle();
            _name = name;
            _price = price;
        }

        public string name()
        {
            return _name;
        }

        public Packing packing()
        {
            return _bottlePacking;
        }

        public float price()
        {
            return _price;
        }
    }

    public class Pepsi : ColdDrink
    {
        public Pepsi(float price, string name = "Pepsi") : base(name, price)
        {
        }
    }

    public class Coke : ColdDrink
    {
        public Coke(float price, string name = "Coke") : base(name, price)
        {
        }
    }
}