using System;
using hungryninja.Models;

namespace hungryninja
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Buffet buff1 = new Buffet();
            Ninja nin1 = new Ninja();
            while(!nin1.IsFull)
            {
                Console.WriteLine(nin1.calorieIntake);
                nin1.Eat(buff1.Serve());
            }
            nin1.Eat(buff1.Serve());
        }
    }
}
