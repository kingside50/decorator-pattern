namespace DecoratorPattern.Beverages
{
    internal class Espresso : Beverage
    {
        private Beverage baseBeverage;

        // Basisdrank
        public Espresso()
        {
            description = "Espresso";
        }

        // Decorator
        public Espresso(Beverage beverage)
        {
            baseBeverage = beverage;
            description = "Espresso";
        }

        public override string GetDescription()
        {
            if (baseBeverage != null)
            {
                return baseBeverage.GetDescription() + ", " + description;
            }
            return description;
        }

        public override double cost()
        {
            double baseCost = 1.99;
            if (baseBeverage != null)
            {
                return baseCost + baseBeverage.cost();
            }
            return baseCost;
        }
    }
}
