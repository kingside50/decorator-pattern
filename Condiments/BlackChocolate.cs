using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class BlackChocolate : CondimentDecorator
    {
        public BlackChocolate(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            double extra = 0.0;

            switch (baseBeverage.Size)
            {
                case Size.Tall:
                    extra = 1.40;
                    break;
                case Size.Grande:
                    extra = 1.50;
                    break;
                case Size.Venti:
                    extra = 1.60;
                    break;
            }

            return baseBeverage.cost() + extra;
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Black Chocolate";
        }
    }
}
