using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Tsunami : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=177
            *  
            *  Destroy all Islands.
            *  
            * Rulings

            *  
            */
        public Tsunami() : base()
        {
            MultiverseId = 177;
            Name = "Tsunami";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.CardType.Sorcery);

            throw new NotImplementedException("Tsunami");
        }
        public Tsunami(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
