using System;
using System.Collections.Generic;
using System.Linq;

namespace Monopoly.Random
{
    public class Randomizer : IRandomizer
    {
        public IEnumerable<T> Randomize<T>(IEnumerable<T> enumerable)
        {
            return enumerable.OrderBy(e => Guid.NewGuid());
        }
    }
}
