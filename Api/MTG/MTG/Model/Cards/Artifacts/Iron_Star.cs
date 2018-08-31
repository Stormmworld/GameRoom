using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Triggered;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Iron_Star : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=21
        *  
        *  Whenever a player casts a red spell, you may pay {1}. If you do, you gain 1 life.
        *  
        * Rulings
        *
        */
        public Iron_Star() : base()
        {
            MultiverseId = 21;
            Name = "Iron Star";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            Add(CardType.Artifact);
            Add(new GainLife(EffectTrigger.Card_Cast, new TargetCardRequirements() { HasColor = Color.Red }, 1));
        }
        public Iron_Star(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
