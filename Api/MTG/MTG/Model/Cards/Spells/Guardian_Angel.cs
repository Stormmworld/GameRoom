using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Casting;
using MTG.Model.Data_Objects;
using MTG.Model.Effects;

namespace MTG.Model.Cards
{
    public class Guardian_Angel : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=252
        *  
        *  Prevent the next X damage that would be dealt to target creature or player this turn. Until end of turn, you may pay {1} any time you could cast an instant. If you do, prevent the next 1 damage that would be dealt to that creature or player this turn.
        *  
        * Rulings
        *
        */
        public Guardian_Angel() : base()
        {
            MultiverseId = 252;
            Name = "Guardian Angel";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, true)));
            abilityCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(CardType.Instant);
            Add(new CreateEffect(abilityCost, new TargetRequirements(TargetScope.Single, TargetType.Player), typeof(PreventDamageEffect), false) { UseXValue = true} );
            Add(new CreateEffect(abilityCost, new TargetRequirements(TargetScope.Single, TargetType.Card, new TargetCardRequirements() { HasType = CardType.Creature , InZone = TargetZone.Battlefield }), typeof(PreventDamageEffect), false) { UseXValue = true });
        }
        public Guardian_Angel(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
