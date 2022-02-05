using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW3.Sweets;
namespace Module2HW3
{
    public static class CandyHelper
    {
        public static Candy[] GetCandies()
        {
            Candy[] candyArray = new Candy[7];
            candyArray[0] = new SuckingCandy("Петушок", "Красный", Taste.Sour, 4.18f);
            candyArray[1] = new NutsFillingCandy("Паркур", "Чёрный", Taste.Sweet, 5.40f, 30f, Nuts.Walnut);
            candyArray[2] = new MarmaladeCandy("Мазель", "Красный", Taste.Sweet, 4.18f, 60f);
            candyArray[3] = new NotPorousCandy("Гуливер", "Чёрный", Taste.Sweet, 7f, 40f);
            candyArray[4] = new PorousCandy("Милка", "Белый", Taste.Sweet, 4.4f, 35f, 23);
            candyArray[5] = new NutsFillingCandy("Ферреро", "Коричневый", Taste.Bitter, 5.6f, 70f, Nuts.PineNut);
            candyArray[6] = new SuckingCandy("Шипучка", "Фиолетовый", Taste.SweetAndSour, 2.3f);
            return candyArray;
        }

        public static void ShowCandiesNames(Candy[] candies)
        {
            foreach (var candy in candies)
            {
                Console.WriteLine(candy);
            }
           
        }
    }
}
