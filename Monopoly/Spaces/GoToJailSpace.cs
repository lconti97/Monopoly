﻿using Monopoly.Events;

namespace Monopoly.Spaces
{
    public class GoToJailSpace : ISpace
    {
        public IEvent EnterSpaceEvent { get; private set; }
        public IEvent LandOnSpaceEvent { get; private set; }

        public GoToJailSpace(INopEvent enterSpaceEvent, IGoToJailEvent landOnSpaceEvent)
        {
            EnterSpaceEvent = enterSpaceEvent;
            LandOnSpaceEvent = landOnSpaceEvent;
        }
    }
}
