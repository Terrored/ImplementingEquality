﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingEquality
{
    public enum FoodGroup { Meat,Vegetables,Fruits,Sweets}

    class FoodItem : IEquatable<FoodItem>
    {
        private readonly string _name;
        private readonly FoodGroup _group;

        public string Name { get { return _name; }}

        public FoodGroup Group { get { return _group; } }


        public FoodItem(string name, FoodGroup group)
        {
            this._name = name;
            this._group = group;
        }

        public override string ToString()
        {
            return _name;
        }



        //Implementating Equality for Value Types

        //Implemanting Interface

        public bool Equals(FoodItem other)
        {
            return this._name == other.Name && this._group == other.Group;
        }

        //Overriding Equals method

        public override bool Equals(object obj)
        {
            if (obj is FoodItem)
            {
                return Equals((FoodItem) obj);
            }
            else
            {
                return false;
            }
        }

        //Implementation of == and != operators.

        public static bool operator ==(FoodItem firstFoodItem, FoodItem secondFoodItem)
        {
            return firstFoodItem.Equals(secondFoodItem);
        }

        public static bool operator !=(FoodItem firstFoodItem, FoodItem secondFoodItem)
        {
            return !firstFoodItem.Equals(secondFoodItem);
        }

        //Implementation of GetHashCode()

        public override int GetHashCode()
        {
            return _name.GetHashCode() ^ _group.GetHashCode();
        }
    }
}
