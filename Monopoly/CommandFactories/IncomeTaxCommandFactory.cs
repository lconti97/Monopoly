using System;
using Monopoly.Commands;

namespace Monopoly.CommandFactories
{
    public class IncomeTaxCommandFactory : IIncomeTaxCommandFactory
    {
        private Int32 maxDeduction;
        private Int32 incomeTaxPercentage;

        public IncomeTaxCommandFactory(Int32 maxDeduction, Int32 incomeTaxPercentage)
        {
            this.maxDeduction = maxDeduction;
            this.incomeTaxPercentage = incomeTaxPercentage;
        }

        public ICommand Create(Player player)
        {
            return new IncomeTaxCommand(player, maxDeduction, incomeTaxPercentage);
        }
    }
}
