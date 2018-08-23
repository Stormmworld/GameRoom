using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Jayemdae_Tome : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=25
            *  
            *  {4}, {T}: Draw a card.
            *  
            * Rulings

            *  
            */
        public Jayemdae_Tome() : base()
        {
            MultiverseId = 25;
            Name = "Jayemdae Tome";
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Jayemdae Tome");
        }
        public Jayemdae_Tome(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
