using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodItem banana = new FoodItem("banana",FoodGroup.Fruits);
            FoodItem banana2 = new FoodItem("banana",FoodGroup.Fruits);
            FoodItem peach = new FoodItem("peach",FoodGroup.Fruits);
            FoodItem salami = new FoodItem("salami",FoodGroup.Meat);

            Console.WriteLine($".Equals -> banana = banana2 :" + banana.Equals(banana2));
            Console.WriteLine($".Equals -> banana = peach :" + banana.Equals(peach));
            Console.WriteLine($".Equals -> banana = salami :" + banana.Equals(salami));
            Console.WriteLine($"'==' -> banana = banana2 :" + (banana==banana2));
            Console.WriteLine($"'==' -> banana = peach :" + (banana==peach));
            Console.WriteLine($"'==' -> banana = salami :" + (banana==salami));

            Console.ReadLine();

        }
    }
}
