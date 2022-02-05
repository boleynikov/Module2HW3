using Module2HW3.Sweets;
using System;

namespace Module2HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            var candies = CandyHelper.GetCandies();

            Console.WriteLine("Для подарка были отобраны конфеты: ");
            CandyHelper.ShowCandiesNames(candies);

            Console.WriteLine($"Вес всех конфет составляет: {candies.CalculateTotalWeight()} грамм.");

            Console.WriteLine("\nТак же можно отсортировать конфеты для удобства их поедания.\nДо сортировки:");
            CandyHelper.ShowCandiesNames(candies);
            Array.Sort(candies);
            Console.WriteLine("\nПосле сортировки:");
            CandyHelper.ShowCandiesNames(candies);

            Console.WriteLine("\nТакже мы можем найти конфету по заданным параметрам вкуса и названия:\nПараметры: Вкус - сладкий, Название - Гуливер");
            Console.WriteLine($"Это {candies.FindCandy(Taste.Sweet, "Гуливер")}\n");

            Console.WriteLine("Думаю стоит пораскрывать конфеты, что бы убедиться, что нас не обманули в кондитерском:");
            foreach (var candy in candies)
            {
                candy.OpenTheWrapper();
            }
        }
    }
}
