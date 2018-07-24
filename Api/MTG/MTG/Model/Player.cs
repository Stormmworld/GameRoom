using MTG.Model.Zones;
using MTG.Model.Objects;
using System;
using MTG.Helpers;
using MTG.Enumerations;
using System.Collections.Generic;
using MTGModel.Objects;
using MTG.Model.Abilities;
using System.Linq;
using MTG.ArgumentDefintions;

namespace MTG.Model
{
    public class Player
    {
        #region Properties
        public int AdditionalTurnCount { get; set; }
        public Battlefield Battlefield { get; set; }
        public Command Command { get; set; }
        public bool Conceded { get; set; }
        public List<Counter> Counters { get; private set; }
        public int DamageTaken { get; set; }
        public Deck Deck { get; private set; }
        public int DrawExtraCards
        {
            get
            {
                throw new NotImplementedException("Player.DrawExtraCards");
            }
        }
        public bool FailedDraw { get; set; }
        public bool ForceLose { get; set; }
        public Graveyard Graveyard { get; set; }
        public Hand Hand { get; set; }
        public int Id { get; set; }
        public Library Library { get; set; }
        public int Life { get; set; }
        public string LoseMessage { get; set; }
        public ManaPool ManaPool { get; set; }
        public string Name { get; set; }
        public List<GamePhases> SkipPhases { get; set; }
        public string SocketId { get; set; }
        public int TeamId { get; set;
        }
        #endregion

        #region Constructors
        public Player()
        {
            ResetPlayer();
        }
        #endregion

        #region EventHandlers
        private void Card_OnCardDestroyed(object sender, EventArgs e)
        {
            Battlefield.Cards.Remove(((CardEventArgs)e).Card);
            Graveyard.AddCard(((CardEventArgs)e).Card);
        }
        #endregion

        #region Methods
        public void AddDamage(int damage)
        {
            DamageTaken = DamageTaken + damage;
        }
        public bool CheckLoseConditions()
        {
            /*
             * https://mtg.gamepedia.com/Ending_the_game
                104.3. There are several ways to lose the game.
                104.3a A player can concede the game at any time. A player who concedes leaves 
                        the game immediately. That player loses the game.
                104.3b If a player’s life total is 0 or less, that player loses the game the next 
                        time a player would receive priority. (This is a state-based action. See rule 704.)
                104.3c If a player is required to draw more cards than are left in their library, 
                        they draw the remaining cards and then lose the game the next time a player would 
                        receive priority. (This is a state-based action. See rule 704.)
                104.3d If a player has ten or more poison counters, that player loses the game the next 
                        time a player would receive priority. (This is a state-based action. See rule 704.)
                104.3e An effect may state that a player loses the game.
                104.3f If a player would both win and lose the game simultaneously, that player loses the 
                        game.
                104.3g In a multiplayer game between teams, a team loses the game if all players on that 
                        team have lost the game.
                104.3h In a multiplayer game using the limited range of influence option (see rule 801), 
                        an effect that states that a player wins the game instead causes all of that player’s 
                        opponents within the player’s range of influence to lose the game. This may not cause 
                        the game to end.
                104.3i In an Emperor game, a team loses the game if its emperor loses the game. 
                        (See rule 809.5.)
                104.3j In a Commander game, a player that’s been dealt 21 or more combat damage by the same 
                        commander over the course of the game loses the game. (This is a state-based action. 
                        See rule 704. See also rule 903.10.)
                104.3k In a tournament, a player may lose the game as a result of a penalty given by a judge. 
                        See rule 100.6.
             */
            if (Conceded)//104.3a 
                LoseMessage = @"Conceded the game";
            else if (Life <= 0)//104.3b 
                LoseMessage = @"No life remaining.";
            else if (Library.Cards.Count == 0 && FailedDraw)//104.3c 
                LoseMessage = @"Not enough cards in current library to complete the required draw.";
            else if (Counters.FindAll(o=>o.CounterType == CounterType.Poison).Count >= 10)//104.3d 
                LoseMessage = @"Poisoned to death (" + Counters.FindAll(o => o.CounterType == CounterType.Poison).Count + " counters)";
            else if (ForceLose)//104.3e 
                LoseMessage = @"Lost the game";
            return !string.IsNullOrEmpty(LoseMessage);
        }
        public void CombineToLibrary(bool hand, bool graveyard)
        {
            if (graveyard)
            {
                Library.Cards.AddRange(Graveyard.Cards);
                Graveyard.Cards.Clear();
            }
            if (hand)
            {
                Library.Cards.AddRange(Hand.Cards);
                Hand.Cards.Clear();
            }
            Library.Shuffle();
        }
        public void Discard(int cardId, int randomCount)
        {
            if (cardId > 0)
                Discard(Hand.Cards.IndexOf(Hand.Cards.First(o => o.Id == cardId)));

            while (randomCount > 0 && Hand.Cards.Count > 0)
            {
                Random random = new Random();
                Discard(random.Next(0, Hand.Cards.Count - 1));
            }
        }
        private void Discard(int cardIndex)
        {
            Graveyard.AddCard(Hand.Cards[cardIndex]);
            Hand.Cards.RemoveAt(cardIndex);
        }
        public void DrawCards(int drawCount)
        {
            if ((drawCount + DrawExtraCards) > Library.Cards.Count)
            {
                FailedDraw = true;
                Hand.Cards.AddRange(Library.Draw(Library.Cards.Count));
            }
            else
                Hand.Cards.AddRange(Library.Draw(drawCount + DrawExtraCards));
        }
        public void EmptyManaPool()
        {
            ManaPool.EmptyManaPool();
        }
        public void PhasePermanents()
        {
            foreach (Card card in Battlefield.Cards.FindAll(o => o.Abilities.Exists(p => p is Phasing)))
                card.PhasedOut = !card.PhasedOut;
        }
        public void ProcessDamage()
        {
            Life = Life - DamageTaken;
            DamageTaken = 0;
            foreach (Card card in Battlefield.Cards)
                card.ProcessDamage();
        }
        public void ResetPlayer()
        {
            AdditionalTurnCount = 0;
            Battlefield = new Battlefield();
            Command = new Command();
            Graveyard = new Graveyard();
            Hand = new Hand();
            Library = new Library();
            Life = 20;
            LoseMessage = @"";
            ManaPool = new ManaPool();
            if (Deck != null)
                SelectDeck(Deck);
            else
                Deck = new Deck();
        }
        public void SelectDeck(Deck deck)
        {
            Deck = deck;
            foreach (Card card in Deck.Cards)
                card.OwnerId = this.Id;
            Library.Cards = Deck.CloneCards();
            Library.Shuffle();
        }
        public void UntapPermanents()
        {
            foreach (Card card in Battlefield.Cards.FindAll(o => o.Tapped))
            {
                if (card.UntapDuringUntapPhase || card.SelectedToUntap)
                {
                    card.Tapped = false;
                    card.SelectedToUntap = false;
                }
            }
        }
        #endregion
    }
}
