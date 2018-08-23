using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Ice_Storm : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=157
            *  
            *  Destroy target land.
            *  
            * Rulings

            *  
            */
        public Ice_Storm() : base()
        {
            MultiverseId = 157;
            Name = "Ice Storm";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.CardType.Sorcery);

            throw new NotImplementedException("Ice Storm");
        }
        public Ice_Storm(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
