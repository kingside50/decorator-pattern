using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class WhiteChocolate : CondimentDecorator
    {
        public WhiteChocolate(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            double extra = 0.0;

            switch (baseBeverage.Size)
            {
                case Size.Tall:
                    extra = 1.20;
                    break;
                case Size.Grande:
                    extra = 1.30;
                    break;
                case Size.Venti:
                    extra = 1.60;
                    break;
            }

            return baseBeverage.cost() + extra;
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", White Chocolate";
        }
    }
}
