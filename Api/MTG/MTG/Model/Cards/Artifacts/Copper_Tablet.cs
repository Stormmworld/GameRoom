using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Abilities.Triggered;
using MTG.Model.Data_Objects;
using System.Collections.Generic;

namespace MTG.Model.Cards
{
    public class Copper_Tablet : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=9
        *  
        *  At the beginning of each player's upkeep, Copper Tablet deals 1 damage to that player.
        *  
        * Rulings
        *
        */
        public Copper_Tablet() : base()
        {
            MultiverseId = 9;
            Name = "Copper Tablet";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            Add(CardType.Artifact);
            Add(new UpkeepDamage(new TargetRequirements(TargetScope.ActivePlayer, TargetType.Player), new Damage(this, 1)));
        }
        public Copper_Tablet(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
