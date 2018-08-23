using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Stone_Rain : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=225
            *  
            *  Destroy target land.
            *  
            * Rulings

            *  
            */
        public Stone_Rain() : base()
        {
            MultiverseId = 225;
            Name = "Stone Rain";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.CardType.Sorcery);

            throw new NotImplementedException("Stone Rain");
        }
        public Stone_Rain(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
