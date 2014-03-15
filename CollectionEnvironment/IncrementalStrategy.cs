using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionEnvironment
{
    public class IncrementalStrategy : GrowthStrategy
    {
        public IncrementalStrategy(int amount)
        {
            _amount = amount;
        }

        private readonly int _amount;

        public override int GetSize(int currentSize)
        {
            return currentSize + _amount;
        }
    }
}
