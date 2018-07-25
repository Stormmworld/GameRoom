using MTG.Enumerations;
using MTG.Model.Abilities;
using MTG.Model.Pending_Actions;
using MTGModel.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MTG.Model.Objects
{
    public class AttackingCreature
    {
        #region Properties
        public int AttackingPlayerId { get; set; }
        public List<Card> Blockers { get; set; }
        public Card Card { get; set; }
        public AttackableTarget Defender { get; set; }
        public int Id { get; set; }
        #endregion

        #region Methods
        public void processDamageToDefender(ActiveGame game, int damageDealt)
        {
            Player defendingPlayer = game.Players.First(o => o.Id == Defender.PlayerId);
            Card planeswalker = defendingPlayer.Battlefield.Cards.FirstOrDefault(o => o.Id == Defender.PlaneswalkerId);
            if (Defender.AttackableType == AttackableType.Planeswalker && planeswalker != null)// card not destroyed 
                    planeswalker.AddDamage(game,damageDealt, Card);
            else if (Defender.AttackableType == AttackableType.Player)
                defendingPlayer.AddDamage(game, damageDealt, Card);
        }
        #endregion
    }
}
