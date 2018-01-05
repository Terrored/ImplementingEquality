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
            // Value equality

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


            // Reference equality

            Food apple = new Food("apple", FoodGroup.Fruits);
            CookedFood stewedApple = new CookedFood("stewed","apple", FoodGroup.Fruits);
            CookedFood bakedApple = new CookedFood("basked","apple", FoodGroup.Fruits);
            CookedFood stewedApple2 = new CookedFood("stewed","apple",FoodGroup.Fruits);
            Food apple2 = new Food("apple",FoodGroup.Fruits);
            
            DisplayWhetherEqual(apple,stewedApple);
            DisplayWhetherEqual(stewedApple,bakedApple);
            DisplayWhetherEqual(stewedApple,stewedApple2);
            DisplayWhetherEqual(apple,apple2);
            DisplayWhetherEqual(apple,apple);

            Console.ReadLine();

        }

        static void DisplayWhetherEqual(Food food1, Food food2)
        {
            if(food1==food2)
                Console.WriteLine(string.Format("{0,12} == {1}",food1,food2));
            else
            {
                Console.WriteLine(string.Format("{0,12} != {1}",food1,food2));
            }
        }
    }
}
