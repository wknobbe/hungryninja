using System;
using hungryninja.Models;

namespace hungryninja
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Buffet buff1 = new Buffet();
            SweetTooth swe1 = new SweetTooth();
            SpiceHound spi1 = new SpiceHound();
            int c1 = 0;
            int c2 = 0;
            while(!swe1.IsFull)
            {
                Console.WriteLine(swe1.calorieIntake);
                c1 ++;
                swe1.Consume(buff1.Serve());
            }
            swe1.Consume(buff1.Serve());
            while(!spi1.IsFull)
            {
                Console.WriteLine(spi1.calorieIntake);
                c2 ++;
                spi1.Consume(buff1.Serve());
            }
            spi1.Consume(buff1.Serve());
            int total = c1 + c2;
            if (c1>c2)
            {
                Console.WriteLine("SweetTooth consumed more than SpicyHound!");
            }
            else
            {
                Console.WriteLine("SpicyHound consumed more than SweetTooth!");
            }
            Console.WriteLine($"Total items consumed: {total}");
        }
    }
}
