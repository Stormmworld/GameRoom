using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Flight : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=106
            *  
            *  Enchant creature
Enchanted creature has flying.
            *  
            * Rulings

            *  
            */
        public Flight() : base()
        {
            MultiverseId = 106;
            Name = "Flight";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Flight");
        }
        public Flight(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
