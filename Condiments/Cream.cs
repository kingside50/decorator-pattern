using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments
{
    internal class Cream : CondimentDecorator
    {
        public Cream(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            double extra = 0.0;

            switch (baseBeverage.Size)
            {
                case Size.Tall:
                    extra = 0.40;
                    break;
                case Size.Grande:
                    extra = 0.50;
                    break;
                case Size.Venti:
                    extra = 0.60;
                    break;
            }

            return baseBeverage.cost() + extra;
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Cream";
        }
    }
}
