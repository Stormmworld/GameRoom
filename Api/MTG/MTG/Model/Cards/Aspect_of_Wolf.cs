using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Aspect_of_Wolf : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=140
            *  
            *  Enchant creature
Enchanted creature gets +X/+Y, where X is half the number of Forests you control, rounded down, and Y is half the number of Forests you control, rounded up.
            *  
            * Rulings
		2009-10-01: The effect is continuously updated based on the number of Forests you control at any given time.

            *  
            */
        public Aspect_of_Wolf() : base()
        {
            MultiverseId = 140;
            Name = "Aspect of Wolf";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Aspect of Wolf");
        }
        public Aspect_of_Wolf(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
