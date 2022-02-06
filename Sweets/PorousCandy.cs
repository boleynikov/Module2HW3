namespace Module2HW3.Sweets
{
    sealed class PorousCandy : ChocoladeCandy
    {
        public int NumberOfHolesInCandy { get; }
        public PorousCandy(string name, string color, Taste taste, float weight, float cacaoPercent, int numberofHolesInCandy) : base(name, color, taste, weight, cacaoPercent)
        {
            NumberOfHolesInCandy = numberofHolesInCandy;
        }
    }
}
