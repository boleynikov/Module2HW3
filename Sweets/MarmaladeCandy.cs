namespace Module2HW3.Sweets
{
    sealed class MarmaladeCandy : Candy
    {
        public float MarmaladeProcent { get; }
        public MarmaladeCandy(string name, string color, Taste taste, float weight, float marmaladeProcent) : base(name, color, taste, weight)
        {
            MarmaladeProcent = marmaladeProcent;
        }
    }
}
