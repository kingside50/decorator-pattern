using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class SugerVanilla : CondimentDecorator
    {
        public SugerVanilla(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            double extra = 0.0;

            switch (baseBeverage.Size)
            {
                case Size.Tall:
                    extra = 1.00;
                    break;
                case Size.Grande:
                    extra = 1.10;
                    break;
                case Size.Venti:
                    extra = 1.20;
                    break;
            }

            return baseBeverage.cost() + extra;
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Sugar Vanilla";
        }
    }
}
