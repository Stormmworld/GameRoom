using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Prodigal_Sorcerer : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=121
            *  
            *  {T}: Prodigal Sorcerer deals 1 damage to target creature or player.
            *  
            * Rulings

            *  
            */
        public Prodigal_Sorcerer() : base()
        {
            MultiverseId = 121;
            Name = "Prodigal Sorcerer";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.SubType.Human);
	Add(Enumerations.SubType.Wizard);
	Add(Enumerations.CardType.Creature);
	_Power = 1;
		_Toughness = 1;

            throw new NotImplementedException("Prodigal Sorcerer");
        }
        public Prodigal_Sorcerer(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
