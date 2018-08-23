using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Obsianus_Golem : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=38
            *  
            *  
            *  
            * Rulings

            *  
            */
        public Obsianus_Golem() : base()
        {
            MultiverseId = 38;
            Name = "Obsianus Golem";
	Add(Enumerations.SubType.Golem);
	Add(Enumerations.CardType.Artifact);
	Add(Enumerations.CardType.Creature);
	_Power = 4;
		_Toughness = 6;

            throw new NotImplementedException("Obsianus Golem");
        }
        public Obsianus_Golem(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
