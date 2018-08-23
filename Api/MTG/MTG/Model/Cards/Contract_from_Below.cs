using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Contract_from_Below : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=52
            *  
            *  Remove Contract from Below from your deck before playing if you're not playing for ante.
Discard your hand, ante the top card of your library, then draw seven cards.
            *  
            * Rulings

            *  
            */
        public Contract_from_Below() : base()
        {
            MultiverseId = 52;
            Name = "Contract from Below";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.CardType.Sorcery);

            throw new NotImplementedException("Contract from Below");
        }
        public Contract_from_Below(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
