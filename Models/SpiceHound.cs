using System;
using hungryninja.Interfaces;

namespace hungryninja.Models
{
    class SpiceHound : Ninja
    {
        public SpiceHound() : base()
        {
            
        }
        public override bool IsFull
        {
            get
            {
                if(calorieIntake > 1200)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public override void Consume(IConsumable item)
        {
            if(!IsFull)
            {
                calorieIntake += item.Calories;
                if (item.IsSpicy)
                {
                    calorieIntake -= 5;
                }
                ConsumptionHistory.Add(item);
                item.GetInfo();
            }
            else
            {
                Console.WriteLine("SpiceHound is full and cannot eat anymore!!");
            }
        }
    }
}