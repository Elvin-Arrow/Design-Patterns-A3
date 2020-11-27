
namespace Design_Pattern_Assignment_3.Data
{
    public class Wrapper : Packing
    {
        public string pack()
        {
            return "Wrapped";
        }
    }


    public abstract class Burger : Item
    {
        private Wrapper _wrapperPacking { get; set; }
        private string _name { get; set; }
        private float _price { get; set; }

        public Burger(string name, float price)
        {
            _wrapperPacking = new Wrapper();
            _name = name;
            _price = price;
        }

        public string name()
        {
            return _name;
        }

        public Packing packing()
        {
            return _wrapperPacking;
        }

        public float price()
        {
            return _price;
        }
    }

    public class VegetableBurger : Burger
    {
        public VegetableBurger(string name, float price) : base(name, price)
        {
        }
    }

    public class ChickenBurger : Burger
    {
        public ChickenBurger(string name, float price) : base(name, price)
        {
        }
    }
}