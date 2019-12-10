using BuilderAndFactoryMethod.Entities;
using System;

namespace BuilderAndFactoryMethod.Factories
{
    public class GoodMeatFactory : IMeatFactory
    {
        private static readonly Random _random = new Random();

        public Meat CreateMeat()
        {
            string[] meats = new string[]
            {
                "Свинина",
                "Баранина",
                "Стейк",
                "Филе бедра индейки",
            };

            return new Meat { Name = meats[_random.Next(0, meats.Length - 1)] };
        }
    }
}
