using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Samite_Healer : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=268
            *  
            *  {T}: Prevent the next 1 damage that would be dealt to target creature or player this turn.
            *  
            * Rulings

            *  
            */
        public Samite_Healer() : base()
        {
            MultiverseId = 268;
            Name = "Samite Healer";
	Add(Enumerations.Colors.White);
	Add(Enumerations.SubType.Human);
	Add(Enumerations.SubType.Cleric);
	Add(Enumerations.CardType.Creature);
	_Power = 1;
		_Toughness = 1;

            throw new NotImplementedException("Samite Healer");
        }
        public Samite_Healer(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
