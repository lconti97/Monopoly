using System.Collections.Generic;

namespace Monopoly.Random
{
    public interface IRandomizer
    {
        IEnumerable<T> Randomize<T>(IEnumerable<T> enumerable);
    }
}
