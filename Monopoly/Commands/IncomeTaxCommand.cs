using System;

namespace Monopoly.Commands
{
    public class IncomeTaxCommand : IIncomeTaxCommand
    {
        private Player player;
        private Int32 maxDeduction;
        private Int32 incomeTaxPercentage;
        private Double incomeTaxDecimal;

        public IncomeTaxCommand(Player player, Int32 maxDeduction, Int32 incomeTaxPercentage)
        {
            this.player = player;
            this.maxDeduction = maxDeduction;
            this.incomeTaxPercentage = incomeTaxPercentage;
            incomeTaxDecimal = incomeTaxPercentage / 100.0;
        }

        public void Execute()
        {
            var tenPercentOfBalanceRoundedDown = (Int32)(player.Balance * incomeTaxDecimal);

            if (tenPercentOfBalanceRoundedDown > maxDeduction)
                player.Balance -= maxDeduction;
            else
                player.Balance -= tenPercentOfBalanceRoundedDown;
        }
    }
}
