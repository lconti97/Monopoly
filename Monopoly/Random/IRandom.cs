using System;

namespace Monopoly.Random
{
    public interface IRandom
    {
        Int32 Next();
        Int32 Next(Int32 maxValue);
        Int32 Next(Int32 minValue, Int32 maxValue);
    }
}
