using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Craw_Wurm : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=146
            *  
            *  
            *  
            * Rulings

            *  
            */
        public Craw_Wurm() : base()
        {
            MultiverseId = 146;
            Name = "Craw Wurm";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.SubType.Wurm);
	Add(Enumerations.CardType.Creature);
	_Power = 6;
		_Toughness = 4;

            throw new NotImplementedException("Craw Wurm");
        }
        public Craw_Wurm(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
