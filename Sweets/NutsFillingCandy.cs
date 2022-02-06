using System;

namespace Module2HW3.Sweets
{
    sealed class NutsFillingCandy : NotPorousCandy
    {
        public Nuts Nuts { get; }
        public NutsFillingCandy(string name, string color, Taste taste, float weight, float cacaoPercent, Nuts nuts) : base(name, color, taste, weight, cacaoPercent)
        {
            Nuts = nuts;
        }
        public override void OpenTheWrapper()
        {
            Console.Write("Конфета ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write($"{Name}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" открыта, можно грызть");
        }
    }
}
