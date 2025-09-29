using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns_3.Visitor
{
    public class JsonExporter : IVisitor
    {
        public void Visit(IAccepter acceptor)
        {
            Console.WriteLine("JsonExporter visited");
        }
    }
}
