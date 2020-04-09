using System;
using System.Collections.Generic;

namespace hungryninja.Models
{
    public class Buffet
    {
        public List<Food> Menu;

        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Fried Chicken", 1000, true, false),
                new Food("Baked Ham", 900, false, true),
                new Food("Roast Beef", 1200, false, false),
                new Food("Jalapeno Poppers", 600, true, false),
                new Food("Sweet Potatoes", 850, false, true),
                new Food("Biscuit", 125, false, false),
                new Food("Apple Pie", 500, false, true),
            };
        }
        public Food Serve()
        {
            Random rand = new Random();
            int idx = rand.Next(0,7);
            return Menu[idx];
        }
    }
}