using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Drudge_Skeletons : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=62
            *  
            *  {B}: Regenerate Drudge Skeletons. (The next time this creature would be destroyed this turn, it isn't. Instead tap it, remove all damage from it, and remove it from combat.)
            *  
            * Rulings

            *  
            */
        public Drudge_Skeletons() : base()
        {
            MultiverseId = 62;
            Name = "Drudge Skeletons";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.SubType.Skeleton);
	Add(Enumerations.CardType.Creature);
	_Power = 1;
		_Toughness = 1;

            throw new NotImplementedException("Drudge Skeletons");
        }
        public Drudge_Skeletons(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
