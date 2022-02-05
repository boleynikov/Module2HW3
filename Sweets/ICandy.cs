namespace Module2HW3.Sweets
{
    public interface ICandy
    {
        string Name { get; }
        string Color { get; }
        Taste Taste { get; }
        float Weight { get; }
        void OpenTheWrapper();
    }
}
