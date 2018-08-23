using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Black_Lotus : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=3
            *  
            *  {T}, Sacrifice Black Lotus: Add three mana of any one color to your mana pool.
            *  
            * Rulings

            *  
            */
        public Black_Lotus() : base()
        {
            MultiverseId = 3;
            Name = "Black Lotus";
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Black Lotus");
        }
        public Black_Lotus(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
