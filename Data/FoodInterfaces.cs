using System;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Pattern_Assignment_3.Data
{
    public interface Item
    {
        public String name();
        public Packing packing();
        public float price();
    }

    public interface Packing
    {
        public String pack();
    }

}