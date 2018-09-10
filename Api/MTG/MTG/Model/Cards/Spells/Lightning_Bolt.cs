using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Casting;
using MTG.Model.Data_Objects;
using MTG.Model.Effects;

namespace MTG.Model.Cards
{
    public class Lightning_Bolt : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=209
        *  
        *  Lightning Bolt deals 3 damage to target creature or player.
        *  
        * Rulings

        *
        */
        public Lightning_Bolt() : base()
        {
            MultiverseId = 209;
            Name = "Lightning Bolt";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(CardType.Instant);
            Add(new CreateEffect(abilityCost, new TargetRequirements(TargetScope.Single, TargetType.Player), typeof(DamageEffect), false) { Damage = new Damage(this, 3) });
            Add(new CreateEffect(abilityCost, new TargetRequirements(TargetScope.Single, TargetType.Card, new TargetCardRequirements() { HasType= CardType.Creature, InZone= TargetZone.Battlefield}), typeof(DamageEffect), false) { Damage = new Damage(this, 3) });
       }
        public Lightning_Bolt(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
