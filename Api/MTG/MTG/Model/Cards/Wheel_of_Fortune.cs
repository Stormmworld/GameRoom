using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Wheel_of_Fortune : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=231
        *  
        *  Each player discards his or her hand, then draws seven cards.
        *  
        * Rulings

        *
        */
        public Wheel_of_Fortune() : base()
        {
            MultiverseId = 231;
            Name = "Wheel of Fortune";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            abilityCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(CardType.Sorcery);

            throw new NotImplementedException("Wheel of Fortune");
        }
        public Wheel_of_Fortune(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
