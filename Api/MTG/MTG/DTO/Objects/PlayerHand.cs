using MTG.Enumerations;
using MTG.Model.Objects;
using MTG.Model.Zones;
using System.Collections.Generic;

namespace MTG.DTO.Objects
{
    public class PlayerHand
    {
        #region Properties
        public bool Revealed { get; set; }
        public List<Spell> Spells { get; set; }
        #endregion

        #region Constructors
        public PlayerHand()
        {
            Spells = new List<Spell>();
        }
        public PlayerHand(Hand hand,bool ActivePlayer, GamePhases activePhase):this()
        {            
            foreach (Card card in hand.Cards)
            {
                switch (activePhase)
                {
                    case GamePhases.PostCombat_Main:
                    case GamePhases.PreCombat_Main:
                        Spells.Add(new Spell(card, ActivePlayer || Spell.InstantSpeed(card)));
                        break;
                    default:
                        Spells.Add(new Spell(card, Spell.InstantSpeed(card)));
                        break;
                }
            }
        }
        #endregion
    }
}
