﻿using System;

namespace Monopoly.Events
{
    public class PassGoEvent : IEvent
    {
        public const Int32 PassGoPay = 200;

        public void Act(Player player, GameBoard gameBoard)
        {
            player.Balance += PassGoPay;
        }
    }
}
