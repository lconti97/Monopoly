namespace Monopoly.Events
{
    public class NopEvent : IEvent
    {
        public void Act(Player player, GameBoard gameBoard)
        { }
    }
}
