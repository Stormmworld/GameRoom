using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Activated;
using MTG.Model.Effects;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Ley_Druid : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=161
        *  
        *  {T}: Untap target land.
        *  
        * Rulings
        * 2004-10-04: The land is untapped as a normal ability that goes on the stack. It is not a mana ability, so it can't be used at times that only mana abilities can be used.
        *
        */
        public Ley_Druid() : base()
        {
            MultiverseId = 161;
            Name = "Ley Druid";
            Set(1, 1);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(SubType.Human);
            Add(SubType.Druid);
            Add(CardType.Creature);
            Add(new EffectGenerator(true, typeof(UntapEffect), new TargetRequirements(TargetScope.Single, TargetType.Card, new TargetCardRequirements() { HasType = CardType.Land, InZone= TargetZone.Battlefield}), GamePhase.None));
        }
        public Ley_Druid(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
