using System;
using System.Collections.Generic;
using hungryninja.Interfaces;

namespace hungryninja.Models
{
    abstract class Ninja
    {
        public int calorieIntake;
        public List<IConsumable> ConsumptionHistory;
        public Ninja()
        {
            calorieIntake = 0;
            ConsumptionHistory = new List<IConsumable>();
        }
        public abstract bool IsFull {get;}
        public abstract void Consume(IConsumable item);
    }
}