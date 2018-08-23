using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class TwoHeaded_Giant_of_Foriys : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=227
            *  
            *  Trample
Two-Headed Giant of Foriys can block an additional creature each combat.
            *  
            * Rulings

            *  
            */
        public TwoHeaded_Giant_of_Foriys() : base()
        {
            MultiverseId = 227;
            Name = "Two-Headed Giant of Foriys";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.SubType.Giant);
	Add(Enumerations.CardType.Creature);
	_Power = 4;
		_Toughness = 4;

            throw new NotImplementedException("Two-Headed Giant of Foriys");
        }
        public TwoHeaded_Giant_of_Foriys(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
