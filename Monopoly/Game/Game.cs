using System;
using System.Collections.Generic;

namespace Monopoly.Game
{
    public class Game
    {
        public IEnumerable<Player> Players { get; set; }
        public Int32 RoundsPlayed { get; set; }
        public Int32 RoundsToPlay { get; set; }
    }
}
