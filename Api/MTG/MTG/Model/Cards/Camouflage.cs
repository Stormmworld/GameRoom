using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Camouflage : Spell
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
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(CardType.Instant);

            throw new NotImplementedException("Camouflage");
        }
        public Camouflage(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
