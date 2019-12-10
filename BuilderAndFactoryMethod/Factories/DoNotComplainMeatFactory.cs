using BuilderAndFactoryMethod.Entities;
using System;

namespace BuilderAndFactoryMethod.Factories
{
    public class DoNotComplainMeatFactory : IMeatFactory
    {
        private static readonly Random _random = new Random();
        public Meat CreateMeat()
        {
            string[] meats = new string[]
            {
                "Свинина",
                "Курица",
                "Баранина"
            };

            return new Meat { Name = meats[_random.Next(0, meats.Length - 1)] };
        }
    }
}
