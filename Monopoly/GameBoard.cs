using System;
using System.Collections.Generic;
using Monopoly.Spaces;

namespace Monopoly
{
    public class GameBoard
    {
        public IEnumerable<ISpace> Spaces { get; set; }
        public Int32 JailSpaceLocation { get; set; }
    }
}
