using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3.Sweets
{
    public static class CandyExtentions
    {
        public static float CalculateTotalWeight(this Candy[] candyArray)
        {
            float sum = 0;
            for (int i = 0; i < candyArray.Length; i++)
            {
                sum += candyArray[i].Weight;
            }
            return sum;
        }
        public static Candy FindCandy(this Candy[] candyArray, Taste taste, string name = null)
        {
            if(name == null)
            {
                for (int i = 0; i < candyArray.Length; i++)
                {
                    if (candyArray[i].Taste == taste)
                        return candyArray[i];
                }
            }
            else
            {
                for (int i = 0; i < candyArray.Length; i++)
                {
                    if (candyArray[i].Taste == taste && candyArray[i].Name == name)
                        return candyArray[i];
                }
            }
            return null;
        }
    }
}
