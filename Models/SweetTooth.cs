using System;
using hungryninja.Interfaces;

namespace hungryninja.Models
{
    class SweetTooth : Ninja
    {
        public SweetTooth() : base()
        {

        }
        public override bool IsFull
        {
            get
            {
                if(calorieIntake > 1500)
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
                if (item.IsSweet)
                {
                    calorieIntake += 10;
                }
                ConsumptionHistory.Add(item);
                item.GetInfo();
            }
            else
            {
                Console.WriteLine("SweetTooth is full and cannot eat anymore!!");
            }
        }
    }
}