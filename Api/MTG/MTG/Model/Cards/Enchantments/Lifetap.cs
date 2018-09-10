using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Triggered;
using MTG.Model.Effects;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Lifetap : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=109
        *  
        *  Whenever a Forest an opponent controls becomes tapped, you gain 1 life.
        *  
        * Rulings
        * 2004-10-04: Gives one life for each and every Forest tapped.
        * 2004-10-04: In multi-player games it affects all opponents.

        *
        */
        public Lifetap() : base()
        {
            MultiverseId = 109;
            Name = "Lifetap";
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1))); ;
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1))); ;
            Add(Color.Blue);
            Add(CardType.Enchantment);
            Add(new EffectGeneratorTriggered(EffectTrigger.Opponent_Taps_Forest, new TargetRequirements(TargetScope.Controller, TargetType.Player), typeof(GainLifeEffect)) { AmountType = AmountType.Defined, Value = 1 });
        }
        public Lifetap(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
