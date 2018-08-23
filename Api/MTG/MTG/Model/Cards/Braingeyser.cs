using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Braingeyser : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=98
            *  
            *  Target player draws X cards.
            *  
            * Rulings

            *  
            */
        public Braingeyser() : base()
        {
            MultiverseId = 98;
            Name = "Braingeyser";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.CardType.Sorcery);

            throw new NotImplementedException("Braingeyser");
        }
        public Braingeyser(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
