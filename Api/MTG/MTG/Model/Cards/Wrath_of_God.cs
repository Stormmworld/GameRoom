using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Wrath_of_God : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=276
            *  
            *  Destroy all creatures. They can't be regenerated.
            *  
            * Rulings

            *  
            */
        public Wrath_of_God() : base()
        {
            MultiverseId = 276;
            Name = "Wrath of God";
	Add(Enumerations.Colors.White);
	Add(Enumerations.CardType.Sorcery);

            throw new NotImplementedException("Wrath of God");
        }
        public Wrath_of_God(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
