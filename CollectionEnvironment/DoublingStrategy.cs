using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionEnvironment
{
    public class DoublingStrategy : GrowthStrategy
    {
        public override int GetSize(int currentSize)
        {
            return currentSize * 2;
        }
    }
}
