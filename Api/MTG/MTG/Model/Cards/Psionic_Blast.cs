using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Psionic_Blast : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=122
            *  
            *  Psionic Blast deals 4 damage to target creature or player and 2 damage to you.
            *  
            * Rulings

            *  
            */
        public Psionic_Blast() : base()
        {
            MultiverseId = 122;
            Name = "Psionic Blast";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Psionic Blast");
        }
        public Psionic_Blast(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
