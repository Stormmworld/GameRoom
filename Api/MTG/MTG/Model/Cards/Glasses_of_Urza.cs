using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Glasses_of_Urza : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=16
            *  
            *  {T}: Look at target player's hand.
            *  
            * Rulings

            *  
            */
        public Glasses_of_Urza() : base()
        {
            MultiverseId = 16;
            Name = "Glasses of Urza";
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Glasses of Urza");
        }
        public Glasses_of_Urza(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
