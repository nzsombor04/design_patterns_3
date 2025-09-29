using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns_3.Decorator
{
    public interface INeptunUser
    {
        public string NeptunCode { get; set; }
        public string Name { get; set; }
        public double Mark { get; set; }
    }
}
