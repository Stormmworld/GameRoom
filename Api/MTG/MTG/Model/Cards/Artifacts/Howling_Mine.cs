using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Triggered;
using MTG.Model.Data_Objects;
using MTG.Model.Effects;

namespace MTG.Model.Cards
{
    public class Howling_Mine : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=18
        *  
        *  At the beginning of each player's draw step, if Howling Mine is untapped, that player draws an additional card.
        *  
        * Rulings
        * 2004-10-04: If Howling Mine leaves the battlefield before it resolves, then the last known tap or untap state of the card is used for resolution.
        * 2004-10-04: It does not trigger at all if this is tapped at the start of the draw step, and it checks this again on resolution.
        * 2004-10-04: The additional draw is separate from any other draw during your draw step. It happens when the triggered ability resolves.
        * 2013-04-15: The triggered ability is put onto the stack after you have already drawn your card for the turn.
        *
        */
        public Howling_Mine() : base()
        {
            MultiverseId = 18;
            Name = "Howling Mine";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            Add(CardType.Artifact);
            Add(new EffectGeneratorTriggered(EffectTrigger.Phases_BegginingPhase_DrawStep, new TargetRequirements(TargetScope.ActivePlayer, TargetType.Player), typeof(DrawCardsEffect)) { Value = 1 });
        }
        public Howling_Mine(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
