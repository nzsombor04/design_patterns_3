using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns_3.Chain1
{
    public class ConditionValidator : ValidatorBase
    {
        public override bool Validate(Person person)
        {
            return person.Condition;
        }
    }
}
