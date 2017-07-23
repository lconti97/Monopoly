namespace Monopoly.Events
{
    public class NopEvent : INopEvent
    {
        public void Act(Player player, GameBoard gameBoard)
        { }
    }
}
