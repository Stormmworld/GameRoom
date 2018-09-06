using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Casting;
using MTG.Model.Data_Objects;
using MTG.Model.Abilities.Triggered;
using MTG.Model.Effects;

namespace MTG.Model.Cards
{
    public class Disintegrate : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=188
        *  
        *  Disintegrate deals X damage to target creature or player. That creature can't be regenerated this turn. If the creature would die this turn, exile it instead.
        *  
        * Rulings
        * 2004-10-04: The "can't regenerate" is an effect of Disintegrate and not an effect of the damage. It works even if the damage is prevented or redirected. If redirected, the damage does not take this effect with it.
        * 2004-10-04: Disintegrated creatures do not go to the graveyard at all before being exiled. They do not trigger abilities which trigger due to a creature going to the graveyard.
        *
        */
        public Disintegrate() : base()
        {
            MultiverseId = 188;
            Name = "Disintegrate";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, true)));
            abilityCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(CardType.Sorcery);
            TargetRequirements targetRequirements = new TargetRequirements(TargetScope.Single, TargetType.Card, new TargetCardRequirements() { HasType = CardType.Creature, InZone= TargetZone.Battlefield});
            Add(new CreateEffect(abilityCost, targetRequirements, typeof(DamageEffect), true) { Damage = new Damage(this, Modifier.Assigned) });
            Add(new CreateEffect(targetRequirements, typeof(PreventRegenerationEffect), true));
            Add(new CreateAbility(targetRequirements, true, new ExileOnEvent(EffectTrigger.Card_Destroyed, GamePhase.Ending_Cleanup)));
        }
        public Disintegrate(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
