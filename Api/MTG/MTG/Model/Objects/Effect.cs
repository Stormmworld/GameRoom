using MTG.Enumerations;
using MTGModel.Objects;
using System;
using System.Linq;

namespace MTG.Model.Objects
{
    public class Effect
    {
        #region Properties
        public bool Boolean { get; set; }
        public EffectTypes EffectType { get; set; }
        public GamePhases EndingPhase { get; set; }
        public Player TargetPlayer { get; set; }
        public Card OriginCard { get; set; }
        public int SecondaryValue { get; set; }//Y
        public Card TargetCard { get; set; }
        public int Value { get; set; }//X
        #endregion

        #region Methods
        public static Effect CreateEffect(ActiveGame game, EffectTypes effectType, int cardId = 0, int playerId = 0, int value = 0, bool boolean = false)
        {
            Player player = game.Players.FirstOrDefault(o => o.Id == playerId);
            Card card = game.FindCard(cardId);
            return new Effect()
            {
                Boolean = boolean,
                EffectType = effectType,
                TargetCard = card,
                TargetPlayer = player,
                Value = value,
            };
        }
        public void ProcessEffect(ActiveGame game)
        {
            switch (EffectType)
            {
                case EffectTypes.CombineHandAndGraveyardToLibrary:
                    if (TargetPlayer != null)
                        TargetPlayer.CombineToLibrary(true, true);
                    break;
                case EffectTypes.CombineGraveyardToLibrary:
                    if (TargetPlayer != null)
                        TargetPlayer.CombineToLibrary(false, true);
                    break;
                case EffectTypes.CombineHandToLibrary:
                    if (TargetPlayer != null)
                        TargetPlayer.CombineToLibrary(true, false);
                    break;
                case EffectTypes.Damage:
                    if (TargetPlayer != null)
                        TargetPlayer.AddDamage(game, Value, OriginCard);
                    else if (TargetCard != null)
                        TargetCard.AddDamage(game, Value, OriginCard);
                    break;
                case EffectTypes.Destroy:
                    if (TargetCard != null)
                    {
                        Player player = game.Players.First(o => o.Id == TargetCard.ControllerId);
                        player.Battlefield.Remove(TargetCard, TargetZone.Graveyard);
                    }
                    break;
                case EffectTypes.DiscardCard:
                    if (TargetPlayer != null && TargetCard != null)
                        TargetPlayer.Hand.Remove(TargetCard, TargetZone.Graveyard);
                    break;
                case EffectTypes.DrawCard:
                    if (TargetPlayer != null)
                        TargetPlayer.Library.Draw(Value);
                    break;
                case EffectTypes.PlaceCardInLibrary_Bottom:
                    if (TargetPlayer != null && TargetCard != null)
                        TargetPlayer.Library.Insert(TargetCard, InsertLocation.Bottom);
                    break;
                case EffectTypes.PlaceCardInLibrary_Top:
                    if (TargetPlayer != null && TargetCard != null)
                        TargetPlayer.Library.Insert(TargetCard, InsertLocation.Top);
                    break;
                case EffectTypes.ShuffleLibrary:
                    if (TargetPlayer != null)
                        TargetPlayer.Library.Shuffle();
                    break;
                case EffectTypes.TopCardOfLibraryFaceUp:
                    if (TargetPlayer != null)
                        TargetPlayer.Library.ShowTopCard = Boolean;
                    break;
                case EffectTypes.RemoveFromGame:

                    if (TargetCard != null)
                    {
                        Player player = game.Players.First(o => o.Id == TargetCard.ControllerId);
                        player.Battlefield.Remove(TargetCard, TargetZone.None);
                        player.Graveyard.Remove(TargetCard, TargetZone.None);
                        player.Hand.Remove(TargetCard, TargetZone.None);
                    }
                    break;
                case EffectTypes.Exile:
                    if (TargetCard != null)
                    {
                        Player player = game.Players.First(o => o.Id == TargetCard.ControllerId);
                        player.Battlefield.Remove(TargetCard, TargetZone.None);
                        game.Stack.Remove(TargetCard, TargetZone.None);
                    }
                    break;
            }
            throw new NotImplementedException("Effect.ProcessEffect");
        }
        #endregion
    }
}
