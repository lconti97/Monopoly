using System;
using Monopoly.Events;

namespace Monopoly.Spaces
{
    public class IncomeTaxSpace : ISpace
    {
        public IEvent EnterSpaceEvent { get; private set; }
        public IEvent LandOnSpaceEvent { get; private set; }

        public IncomeTaxSpace(INopEvent enterSpaceEvent, IIncomeTaxEvent landOnSpaceEvent)
        {
            EnterSpaceEvent = enterSpaceEvent;
            LandOnSpaceEvent = landOnSpaceEvent;
        }
    }
}
