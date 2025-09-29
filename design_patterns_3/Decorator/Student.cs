using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns_3.Decorator
{
    public class Student : INeptunUser
    {
        public Student(string neptunCode, string name, double mark)
        {
            NeptunCode = neptunCode;
            Name = name;
            Mark = mark;
        }

        public string NeptunCode { get; set; }
        public string Name { get; set; }
        public double Mark { get; set; }
    }
}
