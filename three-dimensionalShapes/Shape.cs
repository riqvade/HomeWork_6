using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    internal abstract class Shape
    {
        public string? Name { get; set; }

        public string? Added { get; set; }

        public static List<string>? ExistNames { get; set; } = new List<string>();

        public abstract double Volume();
    }
}
