using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Cockatrice : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=145
            *  
            *  Flying
                Whenever Cockatrice blocks or becomes blocked by a non-Wall creature, destroy that creature at end of combat.
            *  
            * Rulings
		        2004-10-04: The ability destroys the creature at the end of the combat, which is after all first strike and normal damage dealing is done. This means that a creature may have to regenerate twice to survive the combat, once from damage and once again at end of combat.

            *  
            */
        public Cockatrice() : base()
        {
            MultiverseId = 145;
            Name = "Cockatrice";
            _Power = 2;
            _Toughness = 4;
            CastingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Green, Count = 2 } });
            CastingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Colorless, Count = 3 } });
            Add(Enumerations.Colors.Green);
            Add(Enumerations.SubType.Cockatrice);
            Add(Enumerations.CardType.Creature);

            throw new NotImplementedException("Cockatrice");
        }
        public Cockatrice(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
