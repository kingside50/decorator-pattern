using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Ice : CondimentDecorator
    {
        public Ice(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            double extra = 0.0;

            switch (baseBeverage.Size)
            {
                case Size.Tall:
                    extra = 0.10;
                    break;
                case Size.Grande:
                    extra = 0.15;
                    break;
                case Size.Venti:
                    extra = 0.20;
                    break;
            }

            return baseBeverage.cost() + extra;
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Ice";
        }
    }
}
