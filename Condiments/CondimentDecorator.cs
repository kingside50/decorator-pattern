using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments
{
    internal abstract class CondimentDecorator : Beverage
    {
        protected Beverage baseBeverage;

        
        public override Size Size
        {
            get { return baseBeverage.Size; }
            set { baseBeverage.Size = value; }
        }

        public abstract override string GetDescription();
    }
}
