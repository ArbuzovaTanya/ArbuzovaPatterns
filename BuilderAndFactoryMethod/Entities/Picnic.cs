using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderAndFactoryMethod.Entities
{
    public class Picnic
    {
        public List<Meat> Meats { get; set; }

        public List<string> Addition { get; set; }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("На пикнике есть мясо:");
            var meats = Meats.Distinct();

            foreach (Meat meat in meats)
                stringBuilder.AppendLine($"{meat.Name} x {Meats.Count(m => m.Name == meat.Name)}");

            stringBuilder.AppendLine("А также есть: ");

            var adds = Addition.Distinct();
            foreach (string add in adds)
                stringBuilder.AppendLine($"{add} x {Addition.Count(o => o == add)}");

            return stringBuilder.ToString();
        }
    }
}
