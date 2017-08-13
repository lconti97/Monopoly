using Monopoly.Commands;

namespace Monopoly.CommandFactories
{
    public class NullCommandFactory : INullCommandFactory
    {
        public ICommand Create(Player player)
        {
            return new NullCommand();
        }
    }
}
