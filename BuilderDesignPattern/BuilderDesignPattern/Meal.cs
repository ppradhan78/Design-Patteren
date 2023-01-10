﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class Meal
    {
        private List<IItem> items = new List<IItem>();
        public void addItem(IItem item)
        {
            items.Add(item);
        }
        public float getCost()
        {
            float cost = 0.0f;

            foreach (var item in items)
            {
                cost += item.price();

            }
            return cost;
        }
        public void showItems()
        {
            foreach (var item in items)
            {
               Console.WriteLine("Item : " + item.name());
               Console.WriteLine(", Packing : " + item.packing().pack());
               Console.WriteLine(", Price : " + item.price());
            }
        }
    }
}
