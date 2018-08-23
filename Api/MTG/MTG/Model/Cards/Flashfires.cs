using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Flashfires : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=199
            *  
            *  Destroy all Plains.
            *  
            * Rulings

            *  
            */
        public Flashfires() : base()
        {
            MultiverseId = 199;
            Name = "Flashfires";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.CardType.Sorcery);

            throw new NotImplementedException("Flashfires");
        }
        public Flashfires(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
