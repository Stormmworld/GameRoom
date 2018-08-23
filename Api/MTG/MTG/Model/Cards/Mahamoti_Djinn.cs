using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Mahamoti_Djinn : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=112
            *  
            *  Flying (This creature can't be blocked except by creatures with flying or reach.)
            *  
            * Rulings

            *  
            */
        public Mahamoti_Djinn() : base()
        {
            MultiverseId = 112;
            Name = "Mahamoti Djinn";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.SubType.Djinn);
	Add(Enumerations.CardType.Creature);
	_Power = 5;
		_Toughness = 6;

            throw new NotImplementedException("Mahamoti Djinn");
        }
        public Mahamoti_Djinn(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
