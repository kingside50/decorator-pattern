using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Water : Beverage
    {
        private Beverage baseBeverage;

        // Constructor voor basisdrank
        public Water()
        {
            description = "Water";
        }

        // Constructor voor “decorator” gebruik
        public Water(Beverage beverage)
        {
            baseBeverage = beverage;
            description = "Water";
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
            double extra = 0.50;

            if (baseBeverage != null)
            {
                return extra + baseBeverage.cost();
            }

            return extra;
        }
    }
}
