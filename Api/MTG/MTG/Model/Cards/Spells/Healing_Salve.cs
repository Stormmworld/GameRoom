using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Casting;
using MTG.Model.Data_Objects;
using MTG.Model.Effects;

namespace MTG.Model.Cards
{
    public class Healing_Salve : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=253
        *  
        *  Choose one —
        • Target player gains 3 life.
        • Prevent the next 3 damage that would be dealt to target creature or player this turn.
        *  
        * Rulings
        *
        */
        public Healing_Salve() : base()
        {
            MultiverseId = 253;
            Name = "Healing Salve";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(CardType.Instant);
            Add(new CreateEffect(abilityCost, new TargetRequirements(TargetScope.Single, TargetType.Player), typeof(GainLifeEffect), false) { Value = 3 });
            Add(new CreateEffect(abilityCost, new TargetRequirements(TargetScope.Single, TargetType.Card, new TargetCardRequirements() { HasType = CardType.Creature, InZone = TargetZone.Battlefield }), typeof(PreventDamageEffect), false) { Value = 3 });
            Add(new CreateEffect(abilityCost, new TargetRequirements(TargetScope.Single, TargetType.Player), typeof(PreventDamageEffect), false) { Value = 3 });
        }
        public Healing_Salve(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
