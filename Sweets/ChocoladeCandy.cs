namespace Module2HW3.Sweets
{
    class ChocoladeCandy : Candy
    {
        public float CacaoPercent { get; }
        public ChocoladeCandy(string name, string color, Taste taste, float weight, float cacaoPercent) : base(name, color, taste, weight)
        {
            CacaoPercent = cacaoPercent;
        }
    }
}
