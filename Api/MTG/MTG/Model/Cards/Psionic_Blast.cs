using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Psionic_Blast : Spell
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
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            abilityCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(CardType.Instant);

            throw new NotImplementedException("Psionic Blast");
        }
        public Psionic_Blast(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
