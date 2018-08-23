using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Sinkhole : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=85
            *  
            *  Destroy target land.
            *  
            * Rulings

            *  
            */
        public Sinkhole() : base()
        {
            MultiverseId = 85;
            Name = "Sinkhole";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.CardType.Sorcery);

            throw new NotImplementedException("Sinkhole");
        }
        public Sinkhole(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
