using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Casting;
using MTG.Model.Abilities.Static;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Jump : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=108
        *  
        *  Target creature gains flying until end of turn.
        *  
        * Rulings
        * 2009-10-01: To work as an evasion ability, an attacking creature must already have flying when the declare blockers step begins. Once a creature has become blocked, giving it flying won't change that.
        *
        */
        public Jump() : base()
        {
            MultiverseId = 108;
            Name = "Jump";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(CardType.Instant);
            Add(new CreateAbility(abilityCost,new TargetRequirements(TargetScope.Single, TargetType.Card, new TargetCardRequirements() { HasType =  CardType.Creature, InZone = TargetZone.Battlefield}), false, new Flying() { RemoveAtPhase = GamePhase.Ending_Cleanup}));
        }
        public Jump(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
