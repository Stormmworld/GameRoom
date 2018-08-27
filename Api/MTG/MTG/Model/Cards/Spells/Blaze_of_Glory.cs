using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Casting;
using MTG.Model.Data_Objects;
using System.Collections.Generic;
using MTG.Model.Abilities.Static;

namespace MTG.Model.Cards
{
    public class Blaze_of_Glory : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=237
        *  
        *  Cast Blaze of Glory only during combat before blockers are declared.
        *  Target creature defending player controls can block any number of creatures this turn. It blocks each attacking creature this turn if able.
        *  
        * Rulings
        * 2004-10-04: Does not allow a tapped creature to block, or allow a creature to block any creatures it would not normally be able to block.
        * 2013-09-20: If a turn has multiple combat phases, this spell can be cast during any of them as long as it's before the beginning of that phase's Declare Blockers Step.
        *
        */
        public Blaze_of_Glory() : base()
        {
            MultiverseId = 237;
            Name = "Blaze of Glory";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(CardType.Instant);
            Add(new CreateAbility(abilityCost, new TargetRequirements(TargetScope.Single, new List<TargetType>() { TargetType.Creature }, new TargetCardRequirements() { HasType = CardType.Creature, InZone = TargetZone.Battlefield }), false, new BlocksMultipleAttackers(int.MaxValue)));
        }
        public Blaze_of_Glory(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
