using Monopoly.Commands;

namespace Monopoly.CommandFactories
{
    public interface ICommandFactory
    {
        ICommand Create(Player player);
    }
}
