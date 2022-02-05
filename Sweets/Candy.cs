using System;
namespace Module2HW3.Sweets
{
    public class Candy : ICandy, IComparable<Candy>
    {
        public string Name { get; }
        public string Color { get; }
        public Taste Taste { get; }
        public float Weight { get; }

        public Candy(string name, string color, Taste taste, float weight)
        {
            Name = name;
            Color = color;
            Taste = taste;
            Weight = weight;
        }
        public virtual void OpenTheWrapper()
        {
            Console.Write("Конфета ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write($"{Name}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" открыта, можно есть");
        }
        public int CompareTo(Candy candy)
        {
            if(candy is null) throw new ArgumentException("Это не конфета. Сравнить невозможно");
            return Name.CompareTo(candy.Name);
        }
        public override string ToString()
        {
            return $"Конфета {Color} {Name} массой {Weight} гр";
        }
    }
}
