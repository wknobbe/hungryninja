using hungryninja.Interfaces;

namespace hungryninja.Models
{
    public class Drink : IConsumable
    {
        public string Name {get;set;}
        public int Calories {get;set;}
        public bool IsSpicy {get;set;}
        public bool IsSweet {get;set;}
        public string GetInfo()
        {
            return $"{Name} (Drink). Calories: {Calories}. Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
        }
        public Drink(string name, int cal, bool spi, bool swe)
        {
            Name = name;
            Calories = cal;
            IsSpicy = spi;
            IsSweet = swe;
        }
    }
}