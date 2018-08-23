using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Camouflage : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=143
            *  
            *  Cast Camouflage only during your declare attackers step.
This turn, instead of declaring blockers, each defending player chooses any number of creatures he or she controls and divides them into a number of piles equal to the number of attacking creatures for whom that player is the defending player. Creatures he or she controls that can block additional creatures may likewise be put into additional piles. Assign each pile to a different one of those attacking creatures at random. Each creature in a pile that can block the creature that pile is assigned to does so. (Piles can be empty.)
            *  
            * Rulings

            *  
            */
        public Camouflage() : base()
        {
            MultiverseId = 143;
            Name = "Camouflage";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Camouflage");
        }
        public Camouflage(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
