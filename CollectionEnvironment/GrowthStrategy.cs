using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionEnvironment
{
    public abstract class GrowthStrategy
    {
        public abstract int GetSize(int currentSize);
    }
}
