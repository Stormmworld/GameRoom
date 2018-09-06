using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Data_Objects;
using MTG.Model.Abilities.Static;

namespace MTG.Model.Cards
{
    public class Invisibility : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=107
        *  
        *  Enchant creature
        *   Enchanted creature can't be blocked except by Walls.
        *  
        * Rulings
        *
        */
        public Invisibility() :  base(new TargetCardRequirements() { HasType = CardType.Creature, InZone= TargetZone.Battlefield })
        {
            MultiverseId = 107;
            Name = "Invisibility";
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(SubType.Aura);
            Add(CardType.Enchantment);
            Add(new Unblockable(SubType.Wall));
        }
        public Invisibility(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
