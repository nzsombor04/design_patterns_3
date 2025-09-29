using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns_3.Chain1
{
    public abstract class ValidatorBase
    {
        public abstract bool Validate(Person person);
    }
}
