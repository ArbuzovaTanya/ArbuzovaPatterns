using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class WomanInfo
    {
        public string Name { get; set; }
        public List<string> Messages { get; } = new List<string>();
    }
}
