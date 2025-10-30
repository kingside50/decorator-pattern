namespace DecoratorPattern.Beverages
{
    public enum Size
    {
        Tall,
        Grande,
        Venti
    }

    internal abstract class Beverage
    {
       
        public virtual Size Size { get; set; } = Size.Tall;

        protected string description = "Unknown Beverage";

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}
