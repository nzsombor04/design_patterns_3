using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns_3.Chain1
{
    class ValidatorFactory
    {
        public IEnumerable<ValidatorBase> GetValidators()
        {
            return new List<ValidatorBase>
            {
                new AgeValidator(),
                new NameValidator(),
                new ConditionValidator()
            };
        }
    }
}
