using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Bog_Wraith : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=51
            *  
            *  Swampwalk (This creature can't be blocked as long as defending player controls a Swamp.)
            *  
            * Rulings

            *  
            */
        public Bog_Wraith() : base()
        {
            MultiverseId = 51;
            Name = "Bog Wraith";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.SubType.Wraith);
	Add(Enumerations.CardType.Creature);
	_Power = 3;
		_Toughness = 3;

            throw new NotImplementedException("Bog Wraith");
        }
        public Bog_Wraith(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
