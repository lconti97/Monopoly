using System;

namespace Monopoly.Events
{
    public class IncomeTaxEvent : IIncomeTaxEvent
    {
        private Int32 maxDeduction;
        private Int32 incomeTaxPercentage;
        private Double incomeTaxDecimal;

        public IncomeTaxEvent(Int32 maxDeduction, Int32 incomeTaxPercentage)
        {
            this.maxDeduction = maxDeduction;
            this.incomeTaxPercentage = incomeTaxPercentage;
            incomeTaxDecimal = incomeTaxPercentage / 100.0;
        }

        public void Act(Player player, GameBoard gameBoard)
        {
            var tenPercentOfBalanceRoundedDown = (Int32)(player.Balance * incomeTaxDecimal);
            if (tenPercentOfBalanceRoundedDown > maxDeduction)
                player.Balance -= maxDeduction;
            else
                player.Balance -= tenPercentOfBalanceRoundedDown;
        }
    }
}
