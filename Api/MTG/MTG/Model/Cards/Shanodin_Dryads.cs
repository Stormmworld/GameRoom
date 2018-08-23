using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Shanodin_Dryads : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=172
            *  
            *  Forestwalk (This creature can't be blocked as long as defending player controls a Forest.)
            *  
            * Rulings

            *  
            */
        public Shanodin_Dryads() : base()
        {
            MultiverseId = 172;
            Name = "Shanodin Dryads";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.SubType.Nymph);
	Add(Enumerations.SubType.Dryad);
	Add(Enumerations.CardType.Creature);
	_Power = 1;
		_Toughness = 1;

            throw new NotImplementedException("Shanodin Dryads");
        }
        public Shanodin_Dryads(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
