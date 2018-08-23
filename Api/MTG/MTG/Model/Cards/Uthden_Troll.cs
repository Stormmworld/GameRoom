using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Uthden_Troll : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=228
            *  
            *  {R}: Regenerate Uthden Troll.
            *  
            * Rulings

            *  
            */
        public Uthden_Troll() : base()
        {
            MultiverseId = 228;
            Name = "Uthden Troll";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.SubType.Troll);
	Add(Enumerations.CardType.Creature);
	_Power = 2;
		_Toughness = 2;

            throw new NotImplementedException("Uthden Troll");
        }
        public Uthden_Troll(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
