using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns_3.Visitor
{
    public interface IVisitor
    {
        public void Visit(IAccepter acceptor);
    }
}
