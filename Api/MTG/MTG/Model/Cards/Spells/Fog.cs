using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Casting;
using MTG.Model.Data_Objects;
using MTG.Model.Effects;

namespace MTG.Model.Cards
{
    public class Fog : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=149
        *  
        *  Prevent all combat damage that would be dealt this turn.
        *  
        * Rulings
        *
        */
        public Fog() : base()
        {
            MultiverseId = 149;
            Name = "Fog";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(CardType.Instant);
            Add(new CreateEffect(abilityCost, new TargetRequirements(TargetScope.All, TargetType.Player), typeof(PreventDamageEffect), false) { AmountType = AmountType.All, EndingPhase = GamePhase.Combat_Ending});
        }
        public Fog(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
