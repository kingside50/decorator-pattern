using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Beverage espresso = new Espresso();
            espresso.Size = GetRandomSize(rand);
            PrintBeverage(espresso);

            Beverage doppio = new Espresso();
            doppio.Size = GetRandomSize(rand);
            doppio = new Cream(doppio);
            PrintBeverage(doppio);

            Beverage lungo = new Espresso();
            lungo.Size = GetRandomSize(rand);
            lungo = new Water(lungo);
            PrintBeverage(lungo);

            Beverage macchiato = new Espresso();
            macchiato.Size = GetRandomSize(rand);
            macchiato = new MilkFoam(macchiato);
            PrintBeverage(macchiato);

            Beverage corretta = new Espresso();
            corretta.Size = GetRandomSize(rand);
            corretta = new Liqour(corretta);
            PrintBeverage(corretta);

            Beverage conpanna = new Espresso();
            conpanna.Size = GetRandomSize(rand);
            conpanna = new Whip(conpanna);
            PrintBeverage(conpanna);

            Beverage cappuccino = new Espresso();
            cappuccino.Size = GetRandomSize(rand);
            cappuccino = new SteamedMilk(cappuccino);
            cappuccino = new MilkFoam(cappuccino);
            PrintBeverage(cappuccino);

            Beverage americano = new Espresso();
            americano.Size = GetRandomSize(rand);
            americano = new Water(americano);
            americano = new Water(americano);
            PrintBeverage(americano);

            Beverage chocolatemilk = new Chocolate();
            chocolatemilk.Size = GetRandomSize(rand);
            chocolatemilk = new Milk(chocolatemilk);
            chocolatemilk = new Milk(chocolatemilk);
            PrintBeverage(chocolatemilk);

            Beverage mocha = new Espresso();
            mocha.Size = GetRandomSize(rand);
            mocha = new Chocolate(mocha);
            mocha = new SteamedMilk(mocha);
            mocha = new Whip(mocha);
            PrintBeverage(mocha);

            Beverage rafcoffee = new Espresso();
            rafcoffee.Size = GetRandomSize(rand);
            rafcoffee = new SugerVanilla(rafcoffee);
            rafcoffee = new Cream(rafcoffee);
            PrintBeverage(rafcoffee);

            Beverage frappuccino = new Espresso();
            frappuccino.Size = GetRandomSize(rand);
            frappuccino = new Ice(frappuccino);
            frappuccino = new SteamedMilk(frappuccino);
            frappuccino = new Whip(frappuccino);
            PrintBeverage(frappuccino);

            
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine($"{beverage.GetDescription()} ({beverage.Size}) $" +
                              $"{beverage.cost():0.00}");
        }

        static Size GetRandomSize(Random rand)
        {
            // Kies willekeurig Tall, Grande of Venti
            int val = rand.Next(3);
            return (Size)val;
        }
    }
}
