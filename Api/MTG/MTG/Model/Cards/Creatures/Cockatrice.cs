using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Abilities.Static;

namespace MTG.Model.Cards
{
    public class Cockatrice : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=145
        *  
        *  Flying
        *  Whenever Cockatrice blocks or becomes blocked by a non-Wall creature, destroy that creature at end of combat.
        *  
        * Rulings
        * 2004-10-04: The ability destroys the creature at the end of the combat, which is after all first strike and normal damage dealing is done. This means that a creature may have to regenerate twice to survive the combat, once from damage and once again at end of combat.

        *
        */
        public Cockatrice() : base()
        {
            MultiverseId = 145;
            Name = "Cockatrice";
            Set(2, 4);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(SubType.Cockatrice);
            Add(CardType.Creature);
            Add(new Deathtouch());
            Add(new Flying());
        }
        public Cockatrice(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
