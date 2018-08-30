using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Data_Objects;
using MTG.Model.Abilities.Triggered;

namespace MTG.Model.Cards
{
    public class Wooden_Sphere : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=47
        *  
        *  Whenever a player casts a green spell, you may pay {1}. If you do, you gain 1 life.
        *  
        * Rulings
        *
        */
        public Wooden_Sphere() : base()
        {
            MultiverseId = 47;
            Name = "Wooden Sphere";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            Add(CardType.Artifact);
            Add(new GainLife(EffectTrigger.Card_Cast, new TargetCardRequirements() { HasColors = Color.Green }, 1));
        }
        public Wooden_Sphere(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
