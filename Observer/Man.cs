using System;
using System.Linq;

namespace Observer
{
    public class Man : IObserver
    {
        public string Name { get; set; }

        public void Update(object ob)
        {
            var info = ob as WomanInfo;
            Console.WriteLine($"{info.Name} сказала '{info.Messages.Last()}'");
        }
    }
}
