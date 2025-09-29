using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns_3.Decorator
{
    public class ErasmusStudent : INeptunUser
    {
        Student Student;

        public ErasmusStudent(Student student, string anotherUniversity, DateTime returnDate)
        {
            this.Student = student;
            this.AnotherUniversity = anotherUniversity;
            this.ReturnDate = returnDate;
        }

        public string NeptunCode { get => Student.NeptunCode; set => Student.NeptunCode = value; }
        public string Name { get => Student.Name; set => Student.Name = value; }
        public double Mark { get => Student.Mark; set => Student.Mark = value; }
        public string AnotherUniversity { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
