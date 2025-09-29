using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns_3.Visitor
{
    public interface IAccepter
    {
        public void Accept(IVisitor visitor);
    }
}
