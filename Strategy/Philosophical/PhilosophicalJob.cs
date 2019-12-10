using System;

namespace Strategy.Philosophical
{
    public sealed class PhilosophicalJob : IJob
    {
        public void DoJob()
        {
            Console.WriteLine("Ну я типо думаю о создании мира");
        }
    }
}
