using System;

namespace Strategy.Swimmer
{
    public sealed class SwimmerJob : IJob
    {
        public void DoJob()
        {
            Console.WriteLine("Я плаваяю");
        }
    }
}
