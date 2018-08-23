using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Regrowth : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=170
            *  
            *  Return target card from your graveyard to your hand.
            *  
            * Rulings

            *  
            */
        public Regrowth() : base()
        {
            MultiverseId = 170;
            Name = "Regrowth";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.CardType.Sorcery);

            throw new NotImplementedException("Regrowth");
        }
        public Regrowth(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
