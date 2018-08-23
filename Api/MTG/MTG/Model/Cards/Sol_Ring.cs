using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Sol_Ring : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=40
            *  
            *  {T}: Add {C}{C} to your mana pool.
            *  
            * Rulings

            *  
            */
        public Sol_Ring() : base()
        {
            MultiverseId = 40;
            Name = "Sol Ring";
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Sol Ring");
        }
        public Sol_Ring(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
