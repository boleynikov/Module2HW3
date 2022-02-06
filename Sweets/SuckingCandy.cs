using System;

namespace Module2HW3.Sweets
{
    sealed class SuckingCandy : Candy
    {

        public SuckingCandy(string name, string color, Taste taste, float weight) : base(name, color, taste, weight)
        {
        }

        public override void OpenTheWrapper()
        {
            Console.Write("Конфета ");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write($"{Name}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" открыта, можно сосать");
        }
    }
}
