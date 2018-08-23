using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Royal_Assassin : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=79
            *  
            *  {T}: Destroy target tapped creature.
            *  
            * Rulings
		2004-10-04: Can't target itself because you choose the target before you tap him. At that time he is not yet a legal target.
		2004-10-04: If the creature is no longer tapped when the Assassin's ability resolves, then the ability is countered.

            *  
            */
        public Royal_Assassin() : base()
        {
            MultiverseId = 79;
            Name = "Royal Assassin";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.SubType.Human);
	Add(Enumerations.SubType.Assassin);
	Add(Enumerations.CardType.Creature);
	_Power = 1;
		_Toughness = 1;

            throw new NotImplementedException("Royal Assassin");
        }
        public Royal_Assassin(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
