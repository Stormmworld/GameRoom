using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Resurrection : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=265
            *  
            *  Return target creature card from your graveyard to the battlefield.
            *  
            * Rulings

            *  
            */
        public Resurrection() : base()
        {
            MultiverseId = 265;
            Name = "Resurrection";
	Add(Enumerations.Colors.White);
	Add(Enumerations.CardType.Sorcery);

            throw new NotImplementedException("Resurrection");
        }
        public Resurrection(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
