using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingEquality
{
   public sealed class CookedFood: Food
   {
        // implementing equality 
        //u can leave implementation of == and != cause CookedFood derive this methods
       public static bool operator ==(CookedFood x, CookedFood y) //same as base
       {
           return object.Equals(x, y);
       }

       public static bool operator !=(CookedFood x, CookedFood y) //same as base 
       {
           return !object.Equals(x, y);
       }
        public override bool Equals(object obj)
       {
           if (!base.Equals(obj)) // we are using overrided Equals method from Food.cs
               return false;
           CookedFood rhs = (CookedFood) obj;
           return this._cookingMethod == rhs._cookingMethod;
       }

       public override int GetHashCode()
       {
           return base.GetHashCode() ^ this.CookingMethod.GetHashCode();
       }



       private string _cookingMethod;

       public string CookingMethod { get { return _cookingMethod; } }

       public CookedFood(string cookingMethod, string name, FoodGroup group)
           : base(name, group)
       {
           this._cookingMethod = cookingMethod;
       }

       public override string ToString()
       {
           return string.Format($"{_cookingMethod} {Name}");
       }
   }
}
