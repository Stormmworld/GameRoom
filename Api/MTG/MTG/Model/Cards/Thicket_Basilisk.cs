using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Thicket_Basilisk : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=174
        *  
        *  Whenever Thicket Basilisk blocks or becomes blocked by a non-Wall creature, destroy that creature at end of combat.
        *  
        * Rulings
        * 2004-10-04: Protection from Green does not stop the Basilisk's ability because the ability is not targeted.
        * 2004-10-04: The ability destroys the creature at the end of the combat, which is after all first strike and normal damage dealing is done. This means that a creature may have to regenerate twice to survive the combat, once from damage and once again at end of combat.

        *
        */
        public Thicket_Basilisk() : base()
        {
            MultiverseId = 174;
            Name = "Thicket Basilisk";
            Set(2, 4);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(SubType.Basilisk);
            Add(CardType.Creature);

            throw new NotImplementedException("Thicket Basilisk");
        }
        public Thicket_Basilisk(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
