namespace hungryninja.Models
{
    public class Food
    {
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;
        public Food(string name, int cal, bool spi, bool swe)
        {
            Name = name;
            Calories = cal;
            IsSpicy = spi;
            IsSweet = swe;
        }
    }
}