using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Orcish_Oriflamme : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=214
        *  
        *  Attacking creatures you control get +1/+0.
        *  
        * Rulings

        *
        */
        public Orcish_Oriflamme() : base()
        {
            MultiverseId = 214;
            Name = "Orcish Oriflamme";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Orcish Oriflamme");
        }
        public Orcish_Oriflamme(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
