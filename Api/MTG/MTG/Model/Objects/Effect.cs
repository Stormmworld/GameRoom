using MTG.Enumerations;
using MTGModel.Objects;
using System;
using System.Linq;

namespace MTG.Model.Objects
{
    public class Effect
    {
        #region Properties
        public EffectTypes EffectType { get; set; }
        public Player TargetPlayer { get; set; }
        public Card OriginCard { get; set; }
        public Card TargetCard { get; set; }
        public int Value { get; set; }
        public bool Boolean { get; set; }
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
                Value = game.UpkeepRequirements[0].FailedValue,
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
                        TargetPlayer.AddDamage(Value);
                    else if (TargetCard != null)
                        TargetCard.AddDamage(Value, OriginCard.);
                    break;
                case EffectTypes.Destroy:
                    if (TargetCard != null)
                    {
                        foreach (Player player in game.Players)
                        {
                            int cardIndex = player.Battlefield.Cards.IndexOf(TargetCard);
                            if (cardIndex > -1)
                            {
                                player.Graveyard.Cards.Add(TargetCard);
                                player.Battlefield.Cards.RemoveAt(cardIndex);
                                break;
                            }
                        }
                    }
                    break;
                case EffectTypes.DiscardCard:
                    if (TargetPlayer != null && TargetCard != null)
                        TargetPlayer.Hand.Cards.Remove(TargetCard);
                    break;
                case EffectTypes.DrawCard:
                    if (TargetPlayer != null)
                        TargetPlayer.Library.Draw(Value);
                    break;
                case EffectTypes.PlaceCardInLibrary_Bottom:
                    if (TargetPlayer != null && TargetCard != null)
                        TargetPlayer.Library.Cards.Add(TargetCard);
                    break;
                case EffectTypes.PlaceCardInLibrary_Top:
                    if (TargetPlayer != null && TargetCard != null)
                        TargetPlayer.Library.Cards.Insert(0,TargetCard);
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
                        foreach (Player player in game.Players)
                        {
                            int cardIndex = player.Battlefield.Cards.IndexOf(TargetCard);
                            if (cardIndex > -1)
                            {
                                player.Battlefield.Cards.RemoveAt(cardIndex);
                                break;
                            }
                            else
                            {
                                cardIndex = player.Graveyard.Cards.IndexOf(TargetCard);
                                if (cardIndex > -1)
                                {
                                    player.Graveyard.Cards.RemoveAt(cardIndex);
                                    break;
                                }
                            }
                        }
                    }
                    break;
                case EffectTypes.Exile:
                    if (TargetCard != null)
                    {
                        foreach (Player player in game.Players)
                        {
                            int cardIndex = player.Battlefield.Cards.IndexOf(TargetCard);
                            if (cardIndex > -1)
                            {
                                game.Exile.Cards.Add(TargetCard);
                                player.Battlefield.Cards.RemoveAt(cardIndex);
                                break;
                            }
                            else
                            {
                                cardIndex = player.Graveyard.Cards.IndexOf(TargetCard);
                                if (cardIndex > -1)
                                {
                                    game.Exile.Cards.Add(TargetCard);
                                    player.Graveyard.Cards.RemoveAt(cardIndex);
                                    break;
                                }
                            }
                        }
                    }
                    break;
            }
            throw new NotImplementedException();
        }
        public static EffectTypes TranslateEffectType(UpkeepRequirementTypes upkeepRequirement)
        {
            switch (upkeepRequirement)
            {
                case UpkeepRequirementTypes.Damage:
                    return EffectTypes.Damage;
                case UpkeepRequirementTypes.Destroy:
                    return EffectTypes.Destroy;
                case UpkeepRequirementTypes.Discard:
                    return EffectTypes.DiscardCard;
                case UpkeepRequirementTypes.Discard_Random:
                    return EffectTypes.DiscardCard;
                case UpkeepRequirementTypes.Remove_From_Game:
                    return EffectTypes.RemoveFromGame;
                case UpkeepRequirementTypes.Sacrifice_Creature:
                    return EffectTypes.Sacrifice;
                default:
                    return EffectTypes.None;
            }
        }
        #endregion
    }
}
