namespace DecoratorPattern.Beverages
{
    internal class Chocolate : Beverage
    {
        private Beverage baseBeverage;

        // Basisdrank
        public Chocolate()
        {
            description = "Chocolate";
        }

        // Decorator
        public Chocolate(Beverage beverage)
        {
            baseBeverage = beverage;
            description = "Chocolate";
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
            double baseCost = 1.50;
            if (baseBeverage != null)
            {
                return baseCost + baseBeverage.cost();
            }
            return baseCost;
        }
    }
}
