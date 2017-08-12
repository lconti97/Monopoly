namespace Monopoly.Commands
{
    public interface ICommand
    {
        void Execute(Player player);
    }
}
