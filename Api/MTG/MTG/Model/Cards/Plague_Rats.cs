using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Plague_Rats : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=77
        *  
        *  Plague Rats's power and toughness are each equal to the number of creatures named Plague Rats on the battlefield.
        *  
        * Rulings

        *
        */
        public Plague_Rats() : base()
        {
            MultiverseId = 77;
            Name = "Plague Rats";
            //Set(*, *);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(SubType.Rat);
            Add(CardType.Creature);

            throw new NotImplementedException("Plague Rats");
        }
        public Plague_Rats(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
