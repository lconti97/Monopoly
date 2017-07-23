namespace Monopoly.Events
{
    public interface IEvent
    {
        void Act(Player player, GameBoard gameBoard);
    }
}
