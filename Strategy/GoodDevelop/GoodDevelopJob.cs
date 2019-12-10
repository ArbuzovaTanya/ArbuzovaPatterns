using System;

namespace Strategy.GoodDevelop
{
    public sealed class GoodDevelopJob : IJob
    {
        public void DoJob()
        {
            Console.WriteLine("Чиню то, что сломал :)");
        }
    }
}
