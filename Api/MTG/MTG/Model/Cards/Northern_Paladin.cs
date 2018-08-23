using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Northern_Paladin : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=260
            *  
            *  {W}{W}, {T}: Destroy target black permanent.
            *  
            * Rulings

            *  
            */
        public Northern_Paladin() : base()
        {
            MultiverseId = 260;
            Name = "Northern Paladin";
	Add(Enumerations.Colors.White);
	Add(Enumerations.SubType.Human);
	Add(Enumerations.SubType.Knight);
	Add(Enumerations.CardType.Creature);
	_Power = 3;
		_Toughness = 3;

            throw new NotImplementedException("Northern Paladin");
        }
        public Northern_Paladin(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
