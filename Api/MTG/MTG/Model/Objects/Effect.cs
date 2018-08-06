using MTG.ArgumentDefintions;
using MTG.Enumerations;
using System;
using System.Linq;

namespace MTG.Model.Objects
{
    public class Effect
    {
        #region Events
        public event EventHandler OnPendingDamage;
        #endregion

        #region Properties
        public bool Boolean { get; set; }
        public EffectTypes EffectType { get; set; }
        public GamePhases EndingPhase { get; set; }
        public Target Target { get; set; }
        public Card OriginCard { get; set; }
        public int SecondaryValue { get; set; }//Y
        public int Value { get; set; }//X
        #endregion
        
        #region Methods
        public static Effect CreateEffect(ActiveGame game, EffectTypes effectType, Target target, int value = 0, bool boolean = false)
        {
            return new Effect()
            {
                Boolean = boolean,
                EffectType = effectType,
                Target = target,
                Value = value,
            };
        }
        public void ProcessEffect(ActiveGame game)
        {
            switch (EffectType)
            {
                case EffectTypes.AdditionalTurn:

                    break;
                case EffectTypes.CombineHandAndGraveyardToLibrary:
                    //if (TargetPlayer != null)
                    //    TargetPlayer.CombineToLibrary(true, true);
                    break;
                case EffectTypes.CombineGraveyardToLibrary:
                    //if (TargetPlayer != null)
                    //    TargetPlayer.CombineToLibrary(false, true);
                    break;
                case EffectTypes.CombineHandToLibrary:
                    //if (TargetPlayer != null)
                    //    TargetPlayer.CombineToLibrary(true, false);
                    break;
                case EffectTypes.Damage:
                    PendingDamageEventArgs args = new PendingDamageEventArgs()
                    {
                        Damage = new Damage()
                        {
                            OriginCard = OriginCard,
                            BaseValue = Value,
                            Target = Target,
                        }
                    };
                    OnPendingDamage?.Invoke(this, args);
                    return;
                case EffectTypes.Destroy:
                    //if (TargetCard != null)
                    //{
                    //    Player player = game.Players.First(o => o.Id == TargetCard.ControllerId);
                    //    player.Battlefield.Remove(TargetCard, TargetZone.Graveyard);
                    //}
                    break;
                case EffectTypes.DiscardCard:
                    //if (TargetPlayer != null && TargetCard != null)
                    //    TargetPlayer.Hand.Remove(TargetCard, TargetZone.Graveyard);
                    break;
                case EffectTypes.DrawCard:
                    //if (TargetPlayer != null)
                    //    TargetPlayer.Library.Draw(Value);
                    break;
                case EffectTypes.PlaceCardInLibrary_Bottom:
                    //if (TargetPlayer != null && TargetCard != null)
                    //    TargetPlayer.Library.Insert(TargetCard, InsertLocation.Bottom);
                    break;
                case EffectTypes.PlaceCardInLibrary_Top:
                    //if (TargetPlayer != null && TargetCard != null)
                    //    TargetPlayer.Library.Insert(TargetCard, InsertLocation.Top);
                    break;
                case EffectTypes.ShuffleLibrary:
                    //if (TargetPlayer != null)
                    //    TargetPlayer.Library.Shuffle();
                    break;
                case EffectTypes.TopCardOfLibraryFaceUp:
                    //if (TargetPlayer != null)
                    //    TargetPlayer.Library.ShowTopCard = Boolean;
                    break;
                case EffectTypes.RemoveFromGame:

                    //if (TargetCard != null)
                    //{
                    //    Player player = game.Players.First(o => o.Id == TargetCard.ControllerId);
                    //    player.Battlefield.Remove(TargetCard, TargetZone.None);
                    //    player.Graveyard.Remove(TargetCard, TargetZone.None);
                    //    player.Hand.Remove(TargetCard, TargetZone.None);
                    //}
                    break;
                case EffectTypes.Exile:
                    //if (TargetCard != null)
                    //{
                    //    Player player = game.Players.First(o => o.Id == TargetCard.ControllerId);
                    //    player.Battlefield.Remove(TargetCard, TargetZone.None);
                    //    game.Stack.Remove(TargetCard, TargetZone.None);
                    //}
                    break;
            }
            throw new NotImplementedException("Effect.ProcessEffect");
        }
        #endregion
    }
}
