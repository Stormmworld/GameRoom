using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Demonic_Attorney : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=58
        *  
        *  Remove Demonic Attorney from your deck before playing if you're not playing for ante.
Each player antes the top card of his or her library.
        *  
        * Rulings

        *
        */
        public Demonic_Attorney() : base()
        {
            MultiverseId = 58;
            Name = "Demonic Attorney";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            abilityCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            abilityCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(CardType.Sorcery);

            throw new NotImplementedException("Demonic Attorney");
        }
        public Demonic_Attorney(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
