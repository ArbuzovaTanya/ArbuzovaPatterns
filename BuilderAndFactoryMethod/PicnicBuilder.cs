using BuilderAndFactoryMethod.Entities;
using System;
using System.Collections.Generic;

namespace BuilderAndFactoryMethod
{
    public abstract class PicnicBuilder
    {
        private static readonly Random _random = new Random();

        public Picnic Result { get; } = new Picnic();

        public void AddMeats(IMeatFactory factory)
        {
            if (Result.Meats == null)
                Result.Meats = new List<Meat>();

            Result.Meats.Add(factory.CreateMeat());
        }

        public virtual void GenerateAdditional(int countAdds)
        {
            Result.Addition = new List<string>();

            Result.Addition.Add("Тарелка");
            Result.Addition.Add("Приборы");
            Result.Addition.Add("Мангал");
            Result.Addition.Add("Стакан");
            Result.Addition.Add("Шампуры");

            var adds = new string[]
            {
                "Салфетка",
                "Тарелка",
                "Приборы",
                "Салат",
                "Сок",
                "Вода"
            };

            for (int i = 0; i < countAdds; i++)
                Result.Addition.Add(adds[_random.Next(0, adds.Length - 1)]);
        }
    }
}
