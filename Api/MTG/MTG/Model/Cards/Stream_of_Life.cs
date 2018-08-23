using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Stream_of_Life : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=173
            *  
            *  Target player gains X life.
            *  
            * Rulings

            *  
            */
        public Stream_of_Life() : base()
        {
            MultiverseId = 173;
            Name = "Stream of Life";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.CardType.Sorcery);

            throw new NotImplementedException("Stream of Life");
        }
        public Stream_of_Life(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
