using System;
using System.Collections.Generic;
using hungryninja.Interfaces;

namespace hungryninja.Models
{
    public class Buffet
    {
        public List<IConsumable> Menu;

        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Fried Chicken", 100, true, false),
                new Food("Baked Ham", 90, false, true),
                new Food("Roast Beef", 120, false, false),
                new Food("Jalapeno Poppers", 60, true, false),
                new Food("Sweet Potatoes", 85, false, true),
                new Food("Biscuit", 15, false, false),
                new Food("Apple Pie", 50, false, true),
                new Drink("Soda-Pop", 60, false, true),
                new Drink("Chai Tea", 10, true, true),
                new Drink("Milk", 25, false, false),
            };
        }
        public IConsumable Serve()
        {
            Random rand = new Random();
            int idx = rand.Next(0,10);
            return Menu[idx];
        }
    }
}