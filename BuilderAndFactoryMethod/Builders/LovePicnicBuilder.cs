using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderAndFactoryMethod.Builders
{
    public sealed class LovePicnicBuilder : PicnicBuilder
    {
        public override void GenerateAdditional(int countAdds)
        {
            base.GenerateAdditional(countAdds);

            Result.Addition.Add("Красное вино");
            Result.Addition.Add("Красное вино");
            Result.Addition.Add("Простыня");
            Result.Addition.Add("Плед");
        }
    }
}
