using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns_3.Chain1
{
    public class AgeValidator : ValidatorBase
    {
        public override bool Validate(Person person)
        {
            return person.Age >= 18;
        }
    }
}
