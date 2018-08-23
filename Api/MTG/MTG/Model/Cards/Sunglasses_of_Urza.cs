using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Sunglasses_of_Urza : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=42
            *  
            *  You may spend white mana as though it were red mana.
            *  
            * Rulings

            *  
            */
        public Sunglasses_of_Urza() : base()
        {
            MultiverseId = 42;
            Name = "Sunglasses of Urza";
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Sunglasses of Urza");
        }
        public Sunglasses_of_Urza(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
