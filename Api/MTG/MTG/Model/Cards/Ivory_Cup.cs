using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Ivory_Cup : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=22
            *  
            *  Whenever a player casts a white spell, you may pay {1}. If you do, you gain 1 life.
            *  
            * Rulings

            *  
            */
        public Ivory_Cup() : base()
        {
            MultiverseId = 22;
            Name = "Ivory Cup";
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Ivory Cup");
        }
        public Ivory_Cup(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
