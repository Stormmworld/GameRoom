using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Casting;
using MTG.Model.Data_Objects;
using System.Collections.Generic;
using MTG.Model.Counters;
using MTG.Model.Abilities.Triggered;
using MTG.Model.Abilities.Static;

namespace MTG.Model.Cards
{
    public class Berserk : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=141
        *  
        *  Cast Berserk only before the combat damage step.
        *   Target creature gains trample and gets +X/+0 until end of turn, where X is its power. At the beginning of the next end step, destroy that creature if it attacked this turn.
        *  
        * Rulings
        * 2004-10-04: If the permanent stops being a creature before the end of the turn, it is still destroyed.

        *
        */
        public Berserk() : base()
        {
            MultiverseId = 141;
            Name = "Berserk";
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(CardType.Instant);
            Add(new CreateCounter(new CastingCost(), new TargetRequirements(TargetScope.Single, TargetType.Card , new TargetCardRequirements() { HasType = CardType.Creature, InZone = TargetZone.Battlefield }), true, new PlusXPlusY(Incrementer.CurrentPower, Incrementer.None)) { RemoveAtPhase = GamePhase.Ending_Cleanup });
            Add(new CreateAbility(new CastingCost(), new TargetRequirements(TargetScope.Single,  TargetType.Card, new TargetCardRequirements() { HasType = CardType.Creature, InZone = TargetZone.Battlefield }), true, new Trample(GamePhase.Ending_Cleanup)));
            Add(new CreateAbility(new CastingCost(), new TargetRequirements(TargetScope.Single,  TargetType.Card, new TargetCardRequirements() { HasType = CardType.Creature, InZone = TargetZone.Battlefield }), true, new DestroyOnEvent(EffectTrigger.Phases_CombatPhase_EndStep, GameEvent.Creature_Attacked, Id, GamePhase.Ending_Cleanup)));
         }
        public Berserk(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
