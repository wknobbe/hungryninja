using System;
using System.Collections.Generic;

namespace hungryninja.Models
{
    public class Ninja
    {
        public int calorieIntake;
        public List<Food> FoodHistory;
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        public bool IsFull
        {
            get
            {
                if(calorieIntake > 3000)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public void Eat(Food item)
        {
            if(!IsFull)
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine($"Name: {item.Name}, Spicy: {item.IsSpicy}, Sweet: {item.IsSweet}");
            }
            else
            {
                Console.WriteLine("Ninja is full and cannot eat anymore!!");
            }
        }
    }
}