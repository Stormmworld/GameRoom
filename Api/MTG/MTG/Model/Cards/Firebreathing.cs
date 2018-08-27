using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Firebreathing : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=198
        *  
        *  Enchant creature
{R}: Enchanted creature gets +1/+0 until end of turn.
        *  
        * Rulings
        * 2009-10-01: This ability can be activated by Firebreathing's controller, not the enchanted creature's controller (in case they're different players).
        * 2009-10-01: The ability affects whichever creature is enchanted by Firebreathing at the time the ability resolves. The bonus remains even if Firebreathing stops enchanting that creature.

        *
        */
        public Firebreathing() :  base(new TargetCardRequirements() { })
        {
            MultiverseId = 198;
            Name = "Firebreathing";
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(SubType.Aura);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Firebreathing");
        }
        public Firebreathing(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
