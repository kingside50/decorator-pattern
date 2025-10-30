namespace DecoratorPattern.Beverages
{
    internal class Milk : Beverage
    {
        private Beverage baseBeverage;

        // Constructor voor basisdrank
        public Milk()
        {
            description = "Milk";
        }

        // Constructor voor decorator
        public Milk(Beverage beverage)
        {
            baseBeverage = beverage;
            description = "Milk";
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
            double extra = 0.99;
            if (baseBeverage != null)
            {
                return extra + baseBeverage.cost();
            }
            return extra;
        }
    }
}
