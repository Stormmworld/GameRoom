using MTG.Model.Objects;

namespace MTG.ArgumentDefintions
{
    public class AddPlayerToGameArgs
    {
        public string PlayerName { get; set; }
        public Deck SelectedDeck { get; set; }
        public string SocketId { get; set; }
    }
}
